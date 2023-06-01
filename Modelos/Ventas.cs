using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Ventas:RepositorioMaestro
    {

        private int id_ventas;
        private int id_producto;
        private decimal total_venta;
        private decimal total_cantidad;
        private decimal precio;
        private DateTime fechaCreacion;
        
        public int ID_ventas { get { return id_ventas; } set { id_ventas = value; } }
        public int ID_producto { get { return id_producto; } set { id_producto = value; } }
        public decimal Total_venta { get { return total_venta; } set { total_venta = value; } }
        public decimal Total_cantidad { get { return total_cantidad; }  set { total_cantidad = value; } }
        public decimal Precio { get { return precio; } set { precio = value; } }
        public DateTime FechaCreacion { get { return fechaCreacion; } set { fechaCreacion = value; } }


        public Ventas() 
        {

            this.ID_ventas = id_ventas;
            this.ID_producto = id_producto;
            this.Total_venta = total_venta;
            this.Total_cantidad = total_cantidad;
            this.Precio = precio;

        }


        public void GuradarVenta()
        {

            string TranasctSql = "INSERT INTO ventas(total_venta,total_cantidad,precio,fechaCreacion)VALUES(@total_venta, @total_cantidad, @precio, @fechaCreacion)";
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@total_venta", Total_venta));
            parameters.Add(new SqlParameter("@total_cantidad", Total_cantidad));
            parameters.Add(new SqlParameter("@precio", Precio));
            parameters.Add(new SqlParameter("@fechaCreacion", DateTime.Now));
            ExecuteNonQuery(TranasctSql);

        }


        public DataTable MostrarVentas()
        {
            string TransactSql = "SELECT * FROM ventas";
            return ExecuteReader(TransactSql);
        }


    }
}
