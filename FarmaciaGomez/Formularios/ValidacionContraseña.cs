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

namespace FarmaciaGomez.Formularios
{
    public partial class ValidacionContraseña : Form
    {
        public ValidacionContraseña()
        {
            InitializeComponent();
        }

        public string Password { get; private set; }

        private void ValidacionContraseña_Load(object sender, EventArgs e)
        {

           
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Password = txtContraseña.Text;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Password = "";
            this.Close();
        }
    }
}
