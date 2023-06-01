using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;

namespace Controladores
{

    public class ControladorProductos:Productos
    {

        protected List<SqlParameter> parametros;


        #region METODO INSERT, UPDATE Y DELETE;

        protected void ExecuteNonQuery(string transctSql)
        {
            using(var conexion = ConexionBD.GetConnection())
            {
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = transctSql;
                    command.CommandType = CommandType.Text;
                    foreach(SqlParameter item in parametros)
                    {
                        command.Parameters.Add(item);
                    }
                    command.ExecuteNonQuery();
                    parametros.Clear();
                }
            }
        }

        #endregion

        #region LEER TABLA PRODUCTOS

        protected DataTable ExecuteReader(string transactSql)
        {
            using (var conexion = ConexionBD.GetConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = transactSql;
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    using (var tabla = new DataTable())
                    {
                        tabla.Load(reader);
                        reader.Dispose();
                        return tabla;
                    }
                }
            }
        }

        protected DataTable ExecuteReaderParameter(string transactSql)
        {
            using (var conexion = ConexionBD.GetConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = transactSql;
                    command.CommandType = CommandType.Text;
                    
                    foreach(SqlParameter item in parametros)
                    {
                        command.Parameters.Add(item);
                    }
                    SqlDataReader reader = command.ExecuteReader();
                    using (var tabla = new DataTable())
                    {
                        tabla.Load(reader);
                        reader.Dispose();
                        return tabla;
                    }
                }
            }
        }

        #endregion


        #region CRUD PRODUCTOS

        private void GuardarProducto()
        {
            string TransactSql = "INSERT INTO productos(id_proveedor,nombre,tipo,precio,caducidad,lote,cantidad,imagen,fechaCreacion)VALUES(@id_proveedor,@nombre,@tipo,@precio,@caducidad,@lote,@cantidad,@imagen,@fechaCreacion)";
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id_proveedor", ID_proveedor));
            parametros.Add(new SqlParameter("@nombre", Nombre));
            parametros.Add(new SqlParameter("@tipo", Tipo));
            parametros.Add(new SqlParameter("@precio", Precio));
            parametros.Add(new SqlParameter("@caducidad", Caducidad.ToString("yyyy-MM-dd")));
            parametros.Add(new SqlParameter("@lote", Lote));
            parametros.Add(new SqlParameter("@cantidad", Cantidad));
            parametros.Add(new SqlParameter("@imagen", Imagen));
            parametros.Add(new SqlParameter("@fechaCreacion",DateTime.Now));
            ExecuteNonQuery(TransactSql);

        }


        public DataTable VerProductos()
        {
            string TransactSql = "SELECT * FROM productos";
            return ExecuteReader(TransactSql);
        }

        public DataTable MostrarProducto(string palabra)
        {

            string TransactSql = "SELECT * FROM productos WHERE nombre LIKE '%' +@palabra+ '%'";
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@palabra", palabra));
            return ExecuteReaderParameter(TransactSql);

        }


        public Productos MostrarProductoPorId(int id)
        {

            string TransactSql = "SELECT * FROM productos WHERE id_producto = @id";
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id", id));
            DataTable resultado = ExecuteReaderParameter(TransactSql);

            if(resultado.Rows.Count > 0)
            {
                DataRow fila = resultado.Rows[0];
                Productos productos = new Productos
                {
                    ID_producto = Convert.ToInt32(fila["id_producto"]),
                    ID_proveedor = Convert.ToInt32(fila["id_proveedor"]),
                    Nombre = fila["nombre"].ToString(),
                    Tipo = fila["tipo"].ToString(),
                    Precio = Convert.ToDecimal(fila["precio"]),
                    Caducidad = Convert.ToDateTime(fila["caducidad"]),
                    Lote = fila["lote"].ToString(),
                    Cantidad = Convert.ToInt32(fila["cantidad"]),
                    Imagen = (byte[])fila["imagen"],
                    FechCreacion = Convert.ToDateTime(fila["fechaCreacion"])

                };

                return productos;
            }

            return null;
        }


        private void EditarProductos()
        {

            string TransactSql = "UPDATE productos " +
                "SET id_proveedor=@id_proveedor,nombre=@nombre,tipo=@tipo,precio=@precio,caducidad=@caducidad,lote=@lote,cantidad=@cantidad,imagen=@imagen WHERE id_producto=@id";
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id_proveedor",ID_proveedor));
            parametros.Add(new SqlParameter("@nombre", Nombre));
            parametros.Add(new SqlParameter("@tipo", Tipo));
            parametros.Add(new SqlParameter("@precio", Precio));
            parametros.Add(new SqlParameter("@caducidad", Caducidad.ToString("yyyy-MM-dd")));
            parametros.Add(new SqlParameter("@lote", Lote));
            parametros.Add(new SqlParameter("@cantidad", Cantidad));
            parametros.Add(new SqlParameter("@imagen", Imagen));
            parametros.Add(new SqlParameter("@id", ID_producto));
            ExecuteNonQuery(TransactSql);

        }


        private void EliminarProdcuto()
        {

            string TransactSql = "DELETE FROM productos WHERE id_producto=@id";
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id", ID_producto));
            ExecuteNonQuery(TransactSql);
        }


        public string GuardarCambios()
        {
            string mensaje = null;
            try
            {
                switch (estado)
                {
                    case Valores.Agregar:
                        GuardarProducto();
                        mensaje = "Producto Guardado con exito";
                        break;
                    case Valores.Editar:
                        EditarProductos();
                        mensaje = "Producto Editado con exito";
                        break;
                    case Valores.Borrar:
                        EliminarProdcuto();
                        mensaje = "Prodcuto borrado con exito";
                        break;

                }
            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
            }

            return mensaje;
        }

        #endregion
    }
}
