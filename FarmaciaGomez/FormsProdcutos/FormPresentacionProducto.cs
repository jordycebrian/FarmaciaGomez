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

namespace FarmaciaGomez.FormsProdcutos
{
    public partial class FormPresentacionProducto : Form
    {
        public FormPresentacionProducto()
        {
            InitializeComponent();
        }

        private void FormPresentacionProducto_Load(object sender, EventArgs e)
        {

        }

        #region BOTON MINIMIZAR Y CERRAR

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion


        #region MOVER PANTALL

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            MoveScreen.ReleaseCapture();
            MoveScreen.SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        #endregion

    }
}
