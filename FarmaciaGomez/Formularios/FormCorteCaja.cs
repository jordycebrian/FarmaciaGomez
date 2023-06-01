using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.CacheSoftware;

namespace FarmaciaGomez.Formularios
{
    public partial class FormCorteCaja : Form
    {
        public FormCorteCaja()
        {

            InitializeComponent();
            Load += FormCorteCaja_Load;

        }


        private void FormCorteCaja_Load(object sender, EventArgs e)
        {

            txtTotalVentas.Text = Cache.totalVenta.ToString();
            
           
        }


        #region AGREGAR TIPO DE MONEDA Y CANTIDAD DE LAS MISMAS A LA TABLA


        private void btnAgregarMoneda_Click(object sender, EventArgs e)
        {

            if (int.TryParse(comboBoxMonedas.Text, out int tipoMoneda) && int.TryParse(txtCantidadMonedas.Text, out int cantidadMonedas))
            {

                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell cellCantidad = new DataGridViewTextBoxCell();
                cellCantidad.Value = cantidadMonedas;
                row.Cells.Add(cellCantidad);

                DataGridViewTextBoxCell cellTipoDeEfectivo = new DataGridViewTextBoxCell();
                cellTipoDeEfectivo.Value = tipoMoneda;
                row.Cells.Add(cellTipoDeEfectivo);

                DataGridViewTextBoxCell cellTotal = new DataGridViewTextBoxCell();
                cellTotal.Value = tipoMoneda * cantidadMonedas;
                row.Cells.Add(cellTotal);

                dgvCorteCaja.Rows.Add(row);

                LimpiarCampos();
                CargarTotal();
                CierreCaja();
            }
            else
            {
                MessageBox.Show("No hay campos para rellenear");
            }

        }

        private void btnAgregarBilletes_Click(object sender, EventArgs e)
        {

            if (int.TryParse(comboBoxBilletes.Text, out int tipoBilletes) && int.TryParse(txtCantidadBilletes.Text, out int cantidadBilletes))
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell cellCantidad = new DataGridViewTextBoxCell();
                cellCantidad.Value = cantidadBilletes;
                row.Cells.Add(cellCantidad);

                DataGridViewTextBoxCell cellTipodeEfectivo = new DataGridViewTextBoxCell();
                cellTipodeEfectivo.Value = tipoBilletes;
                row.Cells.Add(cellTipodeEfectivo);


                DataGridViewTextBoxCell cellTotal = new DataGridViewTextBoxCell();
                cellTotal.Value = cantidadBilletes * tipoBilletes;
                row.Cells.Add(cellTotal);


                dgvCorteCaja.Rows.Add(row);


                LimpiarCampos();
                CargarTotal();
                CierreCaja();
            }
            else
            {
                MessageBox.Show("Ingrese los datos correctos :/");
            }

        }

        #endregion


        #region CALCULAT TOTAL EFECTIVO


        private void CargarTotal()
        {
            decimal total = 0;
            foreach(DataGridViewRow row in dgvCorteCaja.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    decimal filaTotal;
                    if (decimal.TryParse(row.Cells[2].Value.ToString(), out filaTotal))
                    {
                        total += filaTotal;
                    }
                }
            }

            txtTotalEfectivoEnCaja.Text = total.ToString("N2");
        }


        #endregion


        #region CALCULAR CIERRE DE CAJA

        private void CierreCaja()
        {
            if(decimal.TryParse(txtTotalVentas.Text, out decimal totalVentas) && decimal.TryParse(txtTotalEfectivoEnCaja.Text, out decimal totalEfectivoCaja))
            {
                decimal cierreCaja = totalVentas - totalEfectivoCaja;
                txtCierreDeCaja.Text = cierreCaja.ToString("N2");
            }

            
        }

        #endregion


        #region LIMPIAR CAMPOS

        private void LimpiarCampos()
        {
            txtCantidadBilletes.Clear();
            txtCantidadMonedas.Clear();
            comboBoxBilletes.SelectedIndex = -1;
            comboBoxMonedas.SelectedIndex = -1;
        }

        #endregion


        #region MAXIMIZAR, MINIMIZAR Y CERRAR


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

            FormularioMenu menu = new FormularioMenu();
            menu.Show();
        }

        private void btnMax_Click(object sender, EventArgs e)
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

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }




        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult rppta = MessageBox.Show("¿Desea eliminar el monto?",
                    "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if(rppta == DialogResult.Yes)
                {
                    dgvCorteCaja.Rows.Remove(dgvCorteCaja.CurrentRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


            CargarTotal();
        }
    }
}
