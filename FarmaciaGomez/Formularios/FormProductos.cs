using FarmaciaGomez.FormsProdcutos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Controladores;
using System.IO;
using System.Data.SqlTypes;
using System.Globalization;



namespace FarmaciaGomez.Formularios
{
    public partial class FormProductos : Form
    {

        ControladorProductos controladorProductos = new ControladorProductos();

        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            dataGridView1.DataSource = controladorProductos.VerProductos();
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            var formAgragarProducto = new FormAgregarProducto();
            formAgragarProducto.estado = Valores.Agregar;
            formAgragarProducto.ShowDialog();
            ActualizarDataGrid();
        }

        #region PASAR DATOS DE DATAGRID A FORM PRESENTACION

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var presentacion = new FormPresentacionProducto();
            presentacion.pictureBoxImagen.Image = Image.FromStream(ByteImage());
            presentacion.lblNombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            presentacion.lblTipo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            presentacion.lblPrecio.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            presentacion.lblCaducidad.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            presentacion.lblLote.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            presentacion.lblCantidad.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            presentacion.ShowDialog();

        }

        #endregion


        #region CONVERTIR IMAGEN

        private MemoryStream ByteImage()
        {
            byte[] img = (byte[])dataGridView1.CurrentRow.Cells[8].Value;
            MemoryStream ms = new MemoryStream(img);
            return ms;
        }

        #endregion


        #region BOTON VOLVER

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

            var formMenu = new FormularioMenu();
            formMenu.Show();
            
        }

        #endregion


        #region BOTON MINIMIZAR, MAXIMIZAR Y CERRAR

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();

            var formMenu = new FormularioMenu();
            formMenu.Show();

        }

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

        #endregion


        #region MOVER PANEL

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            MoveScreen.ReleaseCapture();
            MoveScreen.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion


        #region BOTONES BORRAR Y ACTUALIZAR

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {

                controladorProductos.ID_producto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                controladorProductos.estado = Valores.Borrar;
                MessageBox.Show(controladorProductos.GuardarCambios());
                ActualizarDataGrid();

            }
            else
            {
                MessageBox.Show("Selecciona una fila para borrar");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                var formAgregarProducto = new FormAgregarProducto();
                formAgregarProducto.pictureBoxImagenProducto.Image = Image.FromStream(ByteImage());
                formAgregarProducto.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                formAgregarProducto.txtNombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                formAgregarProducto.txtVia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                formAgregarProducto.txtPrecio.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                formAgregarProducto.dateTimePicker1.Value = ((DateTime)dataGridView1.CurrentRow.Cells[5].Value).Date;
                formAgregarProducto.txtLote.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                formAgregarProducto.txtCantidad.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                formAgregarProducto.txtProveedor.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                formAgregarProducto.estado = Valores.Editar;
                formAgregarProducto.ShowDialog();
                ActualizarDataGrid();

            }
            else
            {
                MessageBox.Show("Selecciona una fila del producto a editar");
            }
        }


        #endregion


        #region BUSCAR PRODUCTO POR CAJA DE TEXTO

        private void txtUsuarioBuscado_TextChanged(object sender, EventArgs e)
        {
            var productoEncontrado = controladorProductos.MostrarProducto(txtUsuarioBuscado.Text);

            if(productoEncontrado != null && txtUsuarioBuscado.Text != "")
            {
                dataGridView1.DataSource = productoEncontrado;
            }
            else
            {
                ActualizarDataGrid();
            }
        }

        #endregion

    }
}
