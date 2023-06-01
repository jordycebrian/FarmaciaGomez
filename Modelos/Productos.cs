using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Productos
    {

        private int id_producto;
        private int id_proveedor;
        private string nombre;
        private string tipo;
        private decimal precio;
        private DateTime caducidad;
        private string lote;
        private int cantidad;
        private byte[] imagen;
        private DateTime fechaCreacion;
        public Valores estado;


        public int ID_producto { get { return id_producto; } set { id_producto = value; } }
        public int ID_proveedor { get { return id_proveedor; } set { id_proveedor = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Tipo { get { return tipo; } set { tipo = value; } }
        public decimal Precio { get { return precio; } set { precio = value; } }
        public DateTime Caducidad { get { return caducidad; } set { caducidad = value; } }
        public string Lote { get { return lote; } set { lote = value; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public byte[] Imagen { get { return imagen; } set { imagen = value; } }
        public DateTime FechCreacion { get { return fechaCreacion; } set { fechaCreacion = value; } }

        public Productos()
        {
            this.id_producto = ID_producto;
            this.id_proveedor = ID_proveedor;
            this.nombre = Nombre;
            this.tipo = Tipo;
            this.precio = Precio;
            this.caducidad = Caducidad;
            this.lote = Lote;
            this.cantidad = Cantidad;
            this.imagen = Imagen;
            this.fechaCreacion = FechCreacion;
        }
    }
}
