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
using FarmaciaGomez.Formularios;
using Modelos;
using Modelos.CacheSoftware;

namespace FarmaciaGomez.FormsProveedor
{
    public partial class FormularioProveedor : Form
    {
        private bool ModoEditar = false;

        public FormularioProveedor()
        {
            InitializeComponent();
            //txtProveedorBuscado.TextChanged += txtProveedorBuscado_TextChanged;
        }

        private void FormularioProveedor_Load(object sender, EventArgs e)
        {
            panelLateral.Enabled = false;
            VerTabla();
        }

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


        #region MOSTRAR PROVEEDORES

        public void VerTabla()
        {
            dataGridViewProveedor.DataSource = ControladorProveedor.GetProveedors();
            dataGridViewProveedor.Columns["FechaCreacion"].Visible = false;
        }

        #endregion


        #region BOTONES CRUD PROVEEDORES

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ContraseñaCorrecta())
            {
                ModoEditar = false;
                panelLateral.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dataGridViewProveedor.SelectedRows.Count > 0)
            {
                if (ContraseñaCorrecta())
                {

                    ModoEditar = true;

                    panelLateral.Enabled = true;

                    txtEmpresa.Text = dataGridViewProveedor.CurrentRow.Cells[1].Value.ToString();
                    txtTelefono.Text = dataGridViewProveedor.CurrentRow.Cells[2].Value.ToString();
                    txtCorreo.Text = dataGridViewProveedor.CurrentRow.Cells[3].Value.ToString();


                }


            }
            else
            {
                MessageBox.Show("Selecciona la fila que quieres editar");
            }
        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(dataGridViewProveedor.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewProveedor.CurrentRow.Cells[0].Value);
                if (ContraseñaCorrecta())
                {

                    bool resultado = ControladorProveedor.BorrarProveedor(id);
                    if (resultado)
                    {
                        MessageBox.Show("Proveedor borrado correctamente");
                        VerTabla();
                    }
                    else
                    {
                        MessageBox.Show("Fallo al borrar el proveedor");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona la fila que quieres borrar");
            }
        }

        #endregion


        #region BOTON MINIMIZAR Y CERRAR

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            var formularioMenu = new FormularioMenu();
            formularioMenu.Show();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

            var formularioMenu = new FormularioMenu();
            formularioMenu.Show();
        }

        #endregion


        #region LIMPIAR CAMPOS TEXTBOX

        public void LimpiarCampos()
        {

            txtEmpresa.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

        }

        #endregion


        #region GUARDAR Y CANCELAR BOTONES

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (ModoEditar)
            {
                int id = Convert.ToInt32(dataGridViewProveedor.CurrentRow.Cells[0].Value);

                Proveedor proveedor = new Proveedor();
                proveedor.Empresa = txtEmpresa.Text;
                proveedor.Telefono = txtTelefono.Text;
                proveedor.Correo = txtCorreo.Text;
                proveedor.ID_proveedor = id;

                bool resiltado = ControladorProveedor.EditarProveedro(proveedor);

                if (resiltado)
                {

                    MessageBox.Show("Proveedor editado correctamente");
                    VerTabla();
                    LimpiarCampos();

                }
                else
                {
                   

                    MessageBox.Show("fallo al editar el proveedor :/");
                    LimpiarCampos();
                    panelLateral.Enabled = false;

                    
                }
            }
            else
            {

                Proveedor proveedor = new Proveedor();
                proveedor.Empresa = txtEmpresa.Text;
                proveedor.Telefono = txtTelefono.Text;
                proveedor.Correo = txtCorreo.Text;

                bool resultado = ControladorProveedor.AgregarProveedor(proveedor);

                if (resultado)
                {
                    MessageBox.Show("Proveedor agregado correctamente");
                    VerTabla();
                    LimpiarCampos();
                }
                else
                {

                    MessageBox.Show("fallo al agregar el proveedor :/");
                    LimpiarCampos();
                    panelLateral.Enabled = false;

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


        #region BUSCAR PROVEEDOR

        private void txtProveedorBuscado_TextChanged(object sender, EventArgs e)
        {
            var UsuarioEncontrado = ControladorProveedor.BuscarProveedor(txtProveedorBuscado.Text);

            if(UsuarioEncontrado != null && UsuarioEncontrado.Count > 0)
            {

                dataGridViewProveedor.DataSource = UsuarioEncontrado;

            }
            else
            {
                MessageBox.Show("Usuarios no encontrados");
            }
        }

        #endregion

    }
}
