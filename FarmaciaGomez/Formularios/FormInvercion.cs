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
using Modelos.CacheSoftware;

namespace FarmaciaGomez.Formularios
{

    public partial class FormInvercion : Form
    {

        Ventas ventas = new Ventas();

        public FormInvercion()
        {
            InitializeComponent();
            Load += FormInvercion_Load;
        }

        private void FormInvercion_Load(object sender, EventArgs e)
        {

            MostrarTotal();

            dataGridViewInvercion.DataSource = ventas.MostrarVentas();
            dataGridViewInvercion.Columns[1].Visible = false;
            dataGridViewInvercion.Columns[0].Visible = false;
        }


        #region METODO SUMA TOTALES

        private void MostrarTotal()
        {
            decimal total = 0;
            foreach(DataGridViewRow row in dataGridViewInvercion.Rows)
            {
                if(row.Cells[2].Value != null)
                { 
                    decimal filaTotal;
                    if (decimal.TryParse(row.Cells[2].Value.ToString(), out filaTotal))
                    {
                        total += filaTotal;
                    }
                }  
            }

            Cache.totalVenta = total;
            txtTotalVentas.Text = total.ToString("N2");
        }

        #endregion


        #region BOTON MINIMIZAR, MAXIMIZAR Y CERRAR

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

            FormularioMenu menu = new FormularioMenu();
            menu.Show();

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
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


    }
}
