using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Usuarios
    {
        public int IdUsuario { get; set; }

        public string Nombre { get; set; }

        public string Contrasena { get; set; }

        public string Email { get; set; }

        public string Puesto { get; set; }

        public DateTime FechaCrecion { get; set; } = DateTime.Now;


        public Usuarios() { }

        public Usuarios(string nombre, string contrasena, string email, string puesto) 
        {

            this.Nombre = nombre;
            this.Contrasena = contrasena;
            this.Email = email;
            this.Puesto = puesto;

        }
    }
}
