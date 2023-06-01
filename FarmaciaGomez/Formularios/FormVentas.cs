using Modelos.CacheSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using Modelos;
using System.Drawing.Printing;

namespace FarmaciaGomez.Formularios
{
    public partial class FormVentas : Form
    {

        ControladorProductos controladorProductos = new ControladorProductos();
        
        

        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            #region RELOJ PARA HORA

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_tick;
            timer.Start();

            #endregion

            lblUsuario.Text = "Bienvenido Empleado : " + Cache.usuario;

            #region COLUMNAD DATAGRID

            dataGridViewVentas.Columns.Add("ColumnaID", "ID");
            dataGridViewVentas.Columns.Add("ColumnaNombre", "Nombre");
            dataGridViewVentas.Columns.Add("ColumnaTipo", "Tipo");
            dataGridViewVentas.Columns.Add("ColumnaPrecio", "Precio");
            dataGridViewVentas.Columns.Add("ColumnaCantidad", "Cantidad");
            dataGridViewVentas.Columns.Add("ColumnaTotal", "Total");

            #endregion
        }


        #region METODO HORA Y FECHA

        private void Timer_tick(object sender, EventArgs e)
        {
            lblHoraFecha.Text = DateTime.Now.ToString("dddd, hh:mm tt dd/MM/yyyy");
        }

        #endregion


        #region BOTONES MAXIMIZAR, MINIMIZAR Y CERRAR

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

            var formMenu = new FormularioMenu();
            formMenu.Show();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();

            var formMenu = new FormularioMenu();
            formMenu.Show();

        }


        #endregion


        #region METODO CALCULRA TOTAL

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach(DataGridViewRow row in dataGridViewVentas.Rows)
            {
                if(row.Cells[5].Value != null)
                {
                    decimal filaTotal;
                    if(decimal.TryParse(row.Cells[5].Value.ToString(),out filaTotal))
                    {
                        total += filaTotal;
                    }
                }
                
            }

            txtTotal.Text = total.ToString("N2");
        }

        #endregion


        #region BOTON AGREGAR

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int claveProducto;
            if(int.TryParse(txtCodigoProducto.Text,out claveProducto))
            {
                Productos producto = controladorProductos.MostrarProductoPorId(claveProducto);

                if(producto != null)
                {

                    // Verificar si el producto ya está en la tabla
                    bool productoExistente = false;
                    foreach (DataGridViewRow rows in dataGridViewVentas.Rows)
                    {
                        int idProducto = Convert.ToInt32(rows.Cells[0].Value);
                        if (idProducto == producto.ID_producto)
                        {
                            productoExistente = true;

                            // Actualizar la cantidad y el total
                            int cantidadExistente = Convert.ToInt32(rows.Cells[4].Value);
                            int nuevaCantidad = cantidadExistente + Convert.ToInt32(txtCantidad.Text);
                            rows.Cells[4].Value = nuevaCantidad;
                            rows.Cells[5].Value = nuevaCantidad * producto.Precio;

                            break;
                        }
                    }

                    if (!productoExistente)
                    {
                        Cache.id_proveedores = producto.ID_proveedor;

                        DataGridViewRow row = new DataGridViewRow();

                        DataGridViewTextBoxCell cellID = new DataGridViewTextBoxCell();
                        cellID.Value = producto.ID_producto;
                        row.Cells.Add(cellID);

                        DataGridViewTextBoxCell cellNombre = new DataGridViewTextBoxCell();
                        cellNombre.Value = producto.Nombre;
                        row.Cells.Add(cellNombre);

                        DataGridViewTextBoxCell cellTipo = new DataGridViewTextBoxCell();
                        cellTipo.Value = producto.Tipo;
                        row.Cells.Add(cellTipo);

                        DataGridViewTextBoxCell cellPrecio = new DataGridViewTextBoxCell();
                        cellPrecio.Value = producto.Precio;
                        row.Cells.Add(cellPrecio);

                        DataGridViewTextBoxCell cellCantidad = new DataGridViewTextBoxCell();
                        cellCantidad.Value = txtCantidad.Text;
                        row.Cells.Add(cellCantidad);

                        DataGridViewTextBoxCell cellTotal = new DataGridViewTextBoxCell();
                        cellTotal.Value = Convert.ToInt32(txtCantidad.Text) * producto.Precio;
                        row.Cells.Add(cellTotal);


                        dataGridViewVentas.Rows.Add(row);
                    }

                    CalcularTotal();
                    txtCantidad.Clear();
                    txtCodigoProducto.Clear();
                }
                else
                {
                    MessageBox.Show("No se encontró un producto con la clave ingresada");
                    txtCantidad.Clear();
                    txtCodigoProducto.Clear();
                }
                
            }
            else
            {
                MessageBox.Show("Ingrese la clave del prodcuto :/ ");
            }


        }

        #endregion


        #region LIMPIAR CAMPOS

        private void LimpiarCampos()
        {

            txtTotal.Clear();
            txtCambio.Clear();
            txtPago.Clear();
            dataGridViewVentas.Rows.Clear();

        }

        #endregion


        #region BOTON COBRAR


        private void btnCobrar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtPago.Text))
            {
                decimal total = 0;
                if (decimal.TryParse(txtTotal.Text, out total))
                {
                    int pago = 0;
                    if (int.TryParse(txtPago.Text, out pago))
                    {
                        decimal pagoDecimal = (decimal)pago; // Convertir el pago a decimal para realizar el cálculo
                        if (pagoDecimal > total)
                        {
                            decimal cambio = pagoDecimal - total;
                            txtCambio.Text = cambio.ToString("0.00");
                            MessageBox.Show("Su cambio es de " + cambio.ToString("0.00"));
                            

                            if(total > 0 && pago > 0)
                            {
                                Ventas venta = new Ventas();
                                venta.Total_venta = total;
                                venta.Total_cantidad = pago;
                                venta.Precio = cambio;

                                

                                printDocument1 = new PrintDocument();
                                PrinterSettings ps = new PrinterSettings();
                                printDocument1.PrinterSettings = ps;
                                printDocument1.PrintPage += Imprimir;
                                printDocument1.Print();

                                venta.GuradarVenta();
                            }
                            else
                            {
                                MessageBox.Show("No se guardo venta");
                            }

                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Pago incompleto");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El valor del pago no es válido");
                    }
                }
                else
                {
                    MessageBox.Show("El valor de la cantidad no es válido");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el pago primero");
            }
        }

        #endregion


        #region METODO IMPRIMIR

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font fontTitulo = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
            Font fontnNormal = new Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point);

            int width = 250;
            int y = 20;

            Image img = Properties.Resources.logo_farmacia;

            e.Graphics.DrawImage(img, new Rectangle(85, 0, 80, 80));
            e.Graphics.DrawString("", fontTitulo, Brushes.Black, new RectangleF(0, y += 40, width, y + 40));
            e.Graphics.DrawString("FARMACIA GOMEZ, S.A. DE C.V.", fontTitulo, Brushes.Black, new RectangleF(15, y += 20,width,y + 40));
            e.Graphics.DrawString("FRACC UNIDOS POR LA PATRIA",fontnNormal,Brushes.Black, new RectangleF(40, y += 20,width,y + 40));
            e.Graphics.DrawString("Colonial #666 RIO BRAVO TAM.", fontnNormal, Brushes.Black, new RectangleF(45, y += 10, width, y + 40));

            e.Graphics.DrawLine(Pens.Black, 0, y += 20, width, y);
            e.Graphics.DrawString("CANTIDAD      NOMBRE         PRECIO", fontTitulo, Brushes.Black, new PointF(0,y));
            e.Graphics.DrawLine(Pens.Black, 0, y += 30, width, y);


            // Mostrar productos
            foreach(DataGridViewRow row in dataGridViewVentas.Rows)
            {
                string cantidad = row.Cells[4].Value.ToString();
                string nombre = row.Cells[1].Value.ToString();
                string precio = row.Cells[3].Value.ToString();

                string productoInfo = $"{cantidad, 10} {nombre, 35} {precio, 25}";

                e.Graphics.DrawString(productoInfo, fontnNormal, Brushes.Black, new PointF(0,y));
                y += 10;

            }

            
            //e.Graphics.DrawString(" ", fontnNormal, Brushes.Black, new PointF(0, y += 20));

            // Agregar línea horizontal
            e.Graphics.DrawLine(Pens.Black, 0, y += 20, width, y);

            //Mostrar el total
            decimal totalVenta = decimal.Parse(txtTotal.Text);
            e.Graphics.DrawString("Total :  $" + totalVenta.ToString("N2"), fontnNormal, Brushes.Black, new PointF(0, y += 20));

            int pagoCliente = int.Parse(txtPago.Text);
            e.Graphics.DrawString("Recibido :  $" + pagoCliente.ToString(), fontnNormal, Brushes.Black, new PointF(0, y += 20));

            // Ejemplo: Mostrar el cambio
            decimal cambio = decimal.Parse(txtCambio.Text);
            e.Graphics.DrawString("Cambio :  $" + cambio.ToString("N2"), fontnNormal, Brushes.Black, new PointF(0, y += 20));


            // Agregar línea horizontal
            e.Graphics.DrawLine(Pens.Black, 0, y += 20, width, y);

            e.Graphics.DrawString("GRACIAS POR SU PREFERENCIA!!!", fontTitulo, Brushes.Black, new RectangleF(15, y += 10, width, y + 40));

            string usuario = Cache.usuario;
            e.Graphics.DrawString("Le atendio: " + usuario, fontnNormal, Brushes.Black, new RectangleF(80, y += 20, width, y + 40));

            string DiaHora = DateTime.Now.ToString("dddd, hh:mm tt");
            e.Graphics.DrawString(DiaHora, fontnNormal, Brushes.Black, new RectangleF(0, y += 20, width, y + 40));


            string Fecha = DateTime.Now.ToString("dd/MM/yyyy");
            e.Graphics.DrawString(Fecha, fontnNormal, Brushes.Black, new RectangleF(190, y, width, y + 40));
        }

        #endregion


        #region BOTON CANCELAR

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rppta = MessageBox.Show("¿Desea eliminar el producto?",
                    "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(rppta == DialogResult.Yes)
                {
                    dataGridViewVentas.Rows.Remove(dataGridViewVentas.CurrentRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            CalcularTotal();
        }


        #endregion

    }
}
