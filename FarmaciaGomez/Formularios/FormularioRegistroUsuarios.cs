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
using Modelos.CacheSoftware;

namespace FarmaciaGomez.Formularios
{
    public partial class FormularioRegistroUsuarios : Form
    {
        ControladorUsuarios usuarios = new ControladorUsuarios();
        private bool modoEdicion = false;
        
        public FormularioRegistroUsuarios()
        {

            InitializeComponent();
            panelLateral.Enabled = false;
            txtUsuarioBuscado.TextChanged += txtUsuarioBuscado_TextChanged;

        }

        private void FormularioRegistroUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();

        }


        #region BUSCAR USUARIO

        private void txtUsuarioBuscado_TextChanged(object sender, EventArgs e)
        {

            var usuariosEncontrados = ControladorUsuarios.BuscarUsuario(txtUsuarioBuscado.Text);

            if(usuariosEncontrados != null && usuariosEncontrados.Count > 0)
            {
                dataGridViewUsuarios.DataSource = usuariosEncontrados;
            }
            else
            {
                MessageBox.Show("No se encontraron usuarios.");
            }

        }

        #endregion


        #region METODS CRUD

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (ContraseñaCorrecta())
            {
                panelLateral.Enabled = true;
                txtContrasena.Enabled = true;   
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            if(dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                if (ContraseñaCorrecta())
                {
                    modoEdicion = true;

                    panelLateral.Enabled = true;
                    txtContrasena.Enabled = false;

                    txtNombre.Text = dataGridViewUsuarios.CurrentRow.Cells[1].Value.ToString();
                    txtEmail.Text = dataGridViewUsuarios.CurrentRow.Cells[3].Value.ToString();
                    txtPuesto.Text = dataGridViewUsuarios.CurrentRow.Cells[4].Value.ToString();

                }
            }
            else
            {
                MessageBox.Show("Selecciona la fila del elemento a editar porfavor :)");
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(dataGridViewUsuarios.SelectedRows.Count > 0)
            {

                if (ContraseñaCorrecta())
                {
                    int id = Convert.ToInt32(dataGridViewUsuarios.CurrentRow.Cells[0].Value);

                    bool resultado = ControladorUsuarios.BorrarUsuario(id);

                    if (resultado)
                    {
                        MessageBox.Show("Usuario borrado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Fallo la operación");
                    }
                }
    
            }
            else
            {
                MessageBox.Show("Seleccióna la fila a editar primero");
            }
        }

        #endregion


        #region CARGAR USUARIOS
        public void CargarUsuarios()
        {

            dataGridViewUsuarios.DataSource = ControladorUsuarios.GetUsuarios();
            dataGridViewUsuarios.Columns["Contrasena"].Visible = false;
            dataGridViewUsuarios.Columns["FechaCrecion"].Visible = false;

        }

        #endregion


        #region LIMPIAR CAMPOS DE TEXTO

        public void LimpiarCampos()
        {

            txtNombre.Clear();
            txtContrasena.Clear();
            txtEmail.Clear();
            txtPuesto.Clear();

        }

        #endregion


        #region VERIFICAR CONTRASEÑA

        private bool ContraseñaCorrecta()
        {

            
            ValidacionContraseña vc = new ValidacionContraseña();
            vc.ShowDialog();
            string password = vc.Password;
            if (ControladorUsuarios.IniciarSecion(Cache.usuario, password))
            {
                MessageBox.Show("Contraseña Verificada");
                return true;
            }
            else
            { 
                MessageBox.Show("Constraseña Incorrecta");
                return false;
            }
            
          
            
        }

        #endregion


        #region REGRESAR AL MENU

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormularioMenu formularioMenu = new FormularioMenu();
            formularioMenu.Show();
        }

        #endregion


        #region BOTONES SALIR,MAXIMIZAR Y MINIMUZAR

        private void btnMaximizar_Click(object sender, EventArgs e)
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            var formularioMenu = new FormularioMenu();
            formularioMenu.Show();
        }

        #endregion


        #region BOTON GUARDAR Y CANCELAR DE FORM

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (modoEdicion)
            {
                
                int id = Convert.ToInt32(dataGridViewUsuarios.CurrentRow.Cells[0].Value);

                Usuarios usuarios = new Usuarios();
                usuarios.Nombre = txtNombre.Text;
                usuarios.Email = txtEmail.Text;
                usuarios.Puesto = txtPuesto.Text;
                usuarios.IdUsuario = id;

                bool resultado = ControladorUsuarios.EditarUsuario(usuarios);

                if (resultado)
                {
                    MessageBox.Show("Usuario Editado con exito");
                    CargarUsuarios();
                }
                else
                {
                    MessageBox.Show("Fallo al editar el usuario");
                    LimpiarCampos();
                }

            }
            else
            {
                

                Usuarios usuarios = new Usuarios();
                usuarios.Nombre = txtNombre.Text;
                usuarios.Contrasena = txtContrasena.Text;
                usuarios.Email = txtEmail.Text;
                usuarios.Puesto = txtPuesto.Text;

                bool resultado = ControladorUsuarios.AgregarUsuario(usuarios);

                if (resultado)
                {
                    MessageBox.Show("Usuario registrado con exito");
                    CargarUsuarios();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Fallo al registrar el usuario");
                    LimpiarCampos();
                }

            }

            panelLateral.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelLateral.Enabled = false;
            LimpiarCampos();
        }

        #endregion

       
    }
}
