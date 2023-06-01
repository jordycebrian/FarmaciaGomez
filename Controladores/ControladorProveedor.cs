using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controladores
{
    public class ControladorProveedor
    {

        #region MOSTRAR TODOS LOS PROVEEDORES

        public static List<Proveedor> GetProveedors()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            string query = "SELECT id_proveedor,empresa,telefono,correo FROM proveedores";

            using(SqlConnection conexion = ConexionBD.GetConnection())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, conexion);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Proveedor proveedor = new Proveedor();
                            proveedor.ID_proveedor = reader.GetInt32(0);
                            proveedor.Empresa = reader.GetString(1);
                            proveedor.Telefono = reader.GetString(2);
                            proveedor.Correo = reader.GetString(3);

                            proveedores.Add(proveedor);
                        }

                        reader.Close();
                        
                    }

                    return proveedores;
                }
                catch (Exception ex)
                {
                   
                    return null;
                    
                }
               
            }
        }

        #endregion


        #region AGREGAR PROVEEDOR

        public static bool AgregarProveedor(Proveedor proveedor)
        {
            string query = "INSERT INTO proveedores(empresa,telefono,correo,fechaCreacion)VALUES(@Empresa,@Telefono,@Correo,@FechaCreacion)";

            proveedor.FechaCreacion = DateTime.Now;

            using(SqlConnection conexion = ConexionBD.GetConnection())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@Empresa", proveedor.Empresa);
                    command.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                    command.Parameters.AddWithValue("@Correo", proveedor.Correo);
                    command.Parameters.AddWithValue("@FechaCreacion", proveedor.FechaCreacion);

                    int result = command.ExecuteNonQuery();

                    return result > 0;  
                }
                catch (Exception)
                {

                    
                    return false;
                    
                }
                finally
                {
                    conexion.Close();
                }
                

            }
        }

        #endregion


        #region BUSCAR PROVEEDOR

        public static List<Proveedor> BuscarProveedor(string palabra)
        {
            string query = "SELECT id_proveedor,empresa,telefono,correo FROM proveedores WHERE empresa LIKE '%' +@palabra+ '%'";

            List<Proveedor> proveedores = new List<Proveedor>();

            using(SqlConnection connection = ConexionBD.GetConnection())
            {

                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@palabra", palabra);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Proveedor proveedor = new Proveedor();
                            proveedor.ID_proveedor = reader.GetInt32(0);
                            proveedor.Empresa = reader.GetString(1);
                            proveedor.Telefono = reader.GetString(2);
                            proveedor.Correo = reader.GetString(3);

                            proveedores.Add(proveedor);
                        }

                        return proveedores;
                    }

                    return null;
                }
                catch (Exception)
                {
                    return null;
                }
                finally
                {
                    connection.Close();
                }
                

                

            }
        }

        #endregion


        #region EDITAR PROVEEDOR

        public static bool EditarProveedro(Proveedor proveedor)
        {
            string query = "UPDATE proveedores SET empresa=@Empresa,telefono=@Telefono,correo=@Correo WHERE id_proveedor=@id";

            using(SqlConnection conexion = ConexionBD.GetConnection())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@Empresa", proveedor.Empresa);
                    command.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                    command.Parameters.AddWithValue("@Correo", proveedor.Correo);
                    command.Parameters.AddWithValue("@id", proveedor.ID_proveedor);

                    int resultado = command.ExecuteNonQuery();

                    return resultado > 0;
                }
                catch (Exception)
                { 
                    return false;
                }
                finally
                {
                    conexion.Close();
                }

            }
        }

        #endregion


        #region BORRAR PROVEEDOR

        public static bool BorrarProveedor(int id)
        {
            string query = "DELETE FROM proveedores WHERE id_proveedor=@id";

            using(SqlConnection conexion = ConexionBD.GetConnection())
            {
                try
                {

                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@id", id);

                    int resultado = command.ExecuteNonQuery();

                    return resultado > 0;

                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    conexion.Close();
                }
                
            }
        }

        #endregion

    }
}
