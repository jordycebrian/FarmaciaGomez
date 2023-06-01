using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using FarmaciaGomez.FormsProveedor;
using Modelos;
using Modelos.CacheSoftware;


namespace FarmaciaGomez.Formularios
{
    public partial class FormularioMenu : Form
    {

        

        public FormularioMenu()
        {
            InitializeComponent();
        }

        private void FormularioMenu_Load(object sender, EventArgs e)
        {

            #region RELOJ PARA HORA

            Timer timer = new Timer();
            timer.Interval = 1000; // intervalo de 1 segundo
            timer.Tick += Timer_tick;
            timer.Start();

            #endregion


            #region USUARIO ACTUAL

            lblUsuario.Text = "Usuario: " + Cache.usuario;

            #endregion 

        }

        #region MOSTRAR OPCINES DE MENU BOTONES

        private void btnInvercion_Click(object sender, EventArgs e)
        {
            this.Hide();


           var formularioRegistroUsuarios = new FormularioRegistroUsuarios();
            formularioRegistroUsuarios.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            this.Hide();

            var formularioProveedor = new FormularioProveedor();
            formularioProveedor.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Hide();

            var formularioPorductos = new FormProductos();
            formularioPorductos.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Close();

            var formularioVentas = new FormVentas();
            formularioVentas.Show();
        }


        private void pictureBoxInvercion_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormInvercion formInvercion = new FormInvercion();
            formInvercion.Show();
        }


        private void pictureBoxCorteCaja_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormCorteCaja formCorteCaja = new FormCorteCaja();
            formCorteCaja.Show();
        }

        #endregion


        #region HORA y FECHA

        private void Timer_tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("dddd, hh:mm tt dd/MM/yyyy");
        }
        

        #endregion


        #region BOTONES MINIMIZAR,MAXIMIZAR Y CERRAR

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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


        #region CONTROL DE PANTALLA

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            MoveScreen.ReleaseCapture();
            MoveScreen.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }






        #endregion

       
    }
}
