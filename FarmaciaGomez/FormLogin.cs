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
using FarmaciaGomez.FormsUsuarios;
using Modelos;
using Controladores;
using FarmaciaGomez.Formularios;

namespace FarmaciaGomez
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }



        #region BOTONES

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            this.Hide();

            FormRegistrarUsuaria registrarUsuaria = new FormRegistrarUsuaria();

            registrarUsuaria.Show();

            
        }

        #endregion


        #region BOTONES MAXIMIZAR,MINIMIZAR Y CERRAR

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

        private void btnMiximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion


        #region MOVER PANTALLA CON MOUSE

        private void panelTopLogin_MouseDown(object sender, MouseEventArgs e)
        {
            MoveScreen.ReleaseCapture();
            MoveScreen.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void panelTopLogo_MouseDown(object sender, MouseEventArgs e)
        {
            MoveScreen.ReleaseCapture();
            MoveScreen.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion


        #region METODO INICIAR SECION

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            bool InicioCorrecto = ControladorUsuarios.IniciarSecion(usuario,contrasena);

            if (InicioCorrecto)
            {

                this.Hide();
                FormularioMenu formularioMenu = new FormularioMenu();
                formularioMenu.Show();
                
            }
            else
            {

                lblAviso.Visible = true;
                txtUsuario.Clear();
                txtContrasena.Clear();
                
            }

            
        }

        #endregion


        #region CAJAS DE TEXTO PERSONALIZADA


        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if(txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.White;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if(txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }


        #endregion
    }
}
