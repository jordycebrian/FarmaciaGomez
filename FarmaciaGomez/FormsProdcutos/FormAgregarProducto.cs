using Controladores;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaGomez.FormsProdcutos
{
    public partial class FormAgregarProducto : Form
    {

        public Valores estado;
        public int id = 0;
        
        public FormAgregarProducto()
        {
            InitializeComponent();
        }

        #region Seleccionar imagen para picturbox y metodo guardar


        private void pictureBoxImagenProducto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            DialogResult dr = dialogo.ShowDialog();

            if (dr == DialogResult.OK)
            {
                pictureBoxImagenProducto.Image = Image.FromFile(dialogo.FileName);
            }
        }

        private byte[] ConvertirImagen()
        {

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBoxImagenProducto.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.GetBuffer();

        }


        #endregion


        #region metodo agregar y cerrar botones

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            ControladorProductos controladorProductos = new ControladorProductos();

            controladorProductos.ID_producto = id;
            controladorProductos.Nombre = txtNombre.Text;
            controladorProductos.Tipo = txtVia.Text;
            controladorProductos.Precio = Convert.ToDecimal(txtPrecio.Text);
            controladorProductos.Caducidad = dateTimePicker1.Value.Date;
            controladorProductos.Lote = txtLote.Text;
            controladorProductos.Cantidad = Convert.ToInt32(txtCantidad.Text);
            controladorProductos.Imagen = ConvertirImagen();
            controladorProductos.ID_proveedor = Convert.ToInt32(txtProveedor.Text);
            controladorProductos.estado = estado;
            

            MessageBox.Show(controladorProductos.GuardarCambios());
            LimpiarCampos();
        }

        #endregion


        #region Limpiar campos

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtVia.Clear();
            txtPrecio.Clear();
            dateTimePicker1.Value = dateTimePicker1.MinDate;
            txtLote.Clear();
            txtCantidad.Clear();
            txtProveedor.Clear();
            pictureBoxImagenProducto.Image = Properties.Resources.default_imagen;
        }

        #endregion

       
    }
}
