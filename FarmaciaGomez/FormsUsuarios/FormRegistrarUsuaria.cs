using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmaciaGomez.Formularios;
using Controladores;
using Modelos;

namespace FarmaciaGomez.FormsUsuarios
{
    public partial class FormRegistrarUsuaria : Form
    {
        public FormRegistrarUsuaria()
        {
            InitializeComponent();
        }


        #region BOTON CANCELAR 

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormLogin formLogin = new FormLogin();

            formLogin.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

            FormLogin formLogin = new FormLogin();

            formLogin.Show();
        }

        #endregion


        #region BOTON AGREGAR USUARIO

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string Error = ControladorUsuarios.ValidacionDeCampos(txtNombre.Text,txtContrasena.Text,txtEmail.Text,txtPuesto.Text);
            
            if (Error != null)
            {
                MessageBox.Show(Error, "Error de Validacion" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuarios usuario = new Usuarios();

            usuario.Nombre = txtNombre.Text.Trim();
            usuario.Contrasena = txtContrasena.Text.Trim();
            usuario.Email = txtEmail.Text;
            usuario.Puesto = txtPuesto.Text;

            bool resultado = ControladorUsuarios.AgregarUsuario(usuario);

            if (resultado)
            {
                MessageBox.Show("Usuario agregado correctamente");
                LimpiarCampos();
            }
            else
            {

                MessageBox.Show("Fallo al agregar usuario");
                
            }
        }

        #endregion


        #region LIMPIAR CAMPOS

        public void LimpiarCampos()
        {

            txtNombre.Clear();
            txtContrasena.Clear();
            txtEmail.Clear();
            txtPuesto.Clear();
        }



        #endregion

        #region MOVER CON MOUSE

        private void FormRegistrarUsuaria_MouseDown(object sender, MouseEventArgs e)
        {
            MoveScreen.ReleaseCapture();
            MoveScreen.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

    }
}
