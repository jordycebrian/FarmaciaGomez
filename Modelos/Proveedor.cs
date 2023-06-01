using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Proveedor
    {

        private int id_proveedor;
        private string empresa;
        private string telefono;
        private string correo;
        private DateTime fechaCreacion;


        public int ID_proveedor { get { return id_proveedor; } set { id_proveedor = value; } }
        public string Empresa { get { return empresa; } set { empresa = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string Correo { get { return correo; } set { correo = value; } }
        public DateTime FechaCreacion { get { return fechaCreacion; } set { fechaCreacion = value; } }


        public Proveedor()
        {
            id_proveedor = ID_proveedor;
            empresa = Empresa;
            telefono = Telefono;
            correo = Correo;
            fechaCreacion = FechaCreacion;
        }

    }
}
