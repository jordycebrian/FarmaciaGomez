using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Modelos.CacheSoftware;
using Modelos;
using Controladores;
using System.Windows.Forms;

namespace Controladores
{
    public class ControladorUsuarios
    {

        #region VALIDACION DE CAMPOS

        public static string ValidacionDeCampos(string nombre, string contrasena, string email, string puesto)
        {
            if (string.IsNullOrEmpty(nombre)|| string.IsNullOrEmpty(contrasena) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(puesto))
            {
                return "Todos los campos son requeridos";
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                return "El formato del email no es valido";
            }

            if(contrasena.Length < 8)
            {
                return "La contraseña debe tener más de 8 caracteres";
            }

            if(!Regex.IsMatch(contrasena, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$"))
            {
                return "La contraseña debe contener al menos una letra mayúscula, una letra minúscula y un dígito.";
            }

            return null;
        }

        #endregion


        #region MOSTRAR CAMPOS

        public static List<Usuarios> GetUsuarios()
        {
            
            string query = "SELECT id_usuario,nombre,email,puesto FROM usuarios";
            using(SqlConnection connection = ConexionBD.GetConnection())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query,connection);
                    SqlDataReader reader = command.ExecuteReader();

                    List<Usuarios> usuarios = new List<Usuarios>();

                    while (reader.Read())
                    {
                        Usuarios usuario = new Usuarios();
                        usuario.IdUsuario = reader.GetInt32(0);
                        usuario.Nombre = reader.GetString(1);
                        usuario.Email = reader.GetString(2);
                        usuario.Puesto = reader.GetString(3);

                        usuarios.Add(usuario);
                    }
                    reader.Close();
                    
                    return usuarios;
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


        #region AGREGAR USUARIO

        public static bool AgregarUsuario(Usuarios usuario)
        {
            string query = "INSERT INTO usuarios(nombre,contrasena,email,puesto,fechaCreacion)" +
                "VALUES(@Nombre,@Contrasena,@Email,@Puesto,@FechaCreacion)";


            usuario.FechaCrecion = DateTime.Now;
            string contraEncriptada = Encrypt.GetSHA256(usuario.Contrasena);

            using(SqlConnection connection = ConexionBD.GetConnection())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre",usuario.Nombre);
                    command.Parameters.AddWithValue("@Contrasena", contraEncriptada);
                    command.Parameters.AddWithValue("@Email", usuario.Email);
                    command.Parameters.AddWithValue("@Puesto", usuario.Puesto);
                    command.Parameters.AddWithValue("@FechaCreacion", usuario.FechaCrecion);

                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }
                catch (Exception)
                {

                    return false;

                }
                finally
                {
                    connection.Close();
                }
            }

        }

        #endregion


        #region BUSCAR USUARIO

        public static List<Usuarios> BuscarUsuario(string palabra)
        {

            List<Usuarios> usuarios = new List<Usuarios>();
            
            string query = "SELECT id_usuario,nombre,email,puesto FROM usuarios WHERE nombre LIKE '%' +@palabra+ '%' ";

            using(SqlConnection connection = ConexionBD.GetConnection())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@palabra",palabra);

                    SqlDataReader reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        Usuarios usuario = new Usuarios();
                        usuario = new Usuarios();
                        usuario.IdUsuario = reader.GetInt32(0);
                        usuario.Nombre = reader.GetString(1);
                        usuario.Email = reader.GetString(2);
                        usuario.Puesto = reader.GetString(3);

                        usuarios.Add(usuario);
                    }

                    reader.Close();

                    return usuarios;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR : " + ex);
                    return null;

                }
                finally
                {
                    connection.Close();
                }
            }
            
        }

        #endregion


        #region EDITAR USUARIO

        public static bool EditarUsuario(Usuarios usuario)
        {
            string query = "UPDATE usuarios SET nombre=@nombre,email=@email,puesto=@puesto WHERE id_usuario=@id";

            using(SqlConnection connection = ConexionBD.GetConnection())
            {
                try
                {

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@email", usuario.Email);
                    command.Parameters.AddWithValue("@puesto", usuario.Puesto);
                    command.Parameters.AddWithValue("@id", usuario.IdUsuario);

                    int result = command.ExecuteNonQuery();

                    return result > 0;

                }
                catch (Exception ex)
                {
                    
                    return false;
                    
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        #endregion


        #region BORRAR USUARIO

        public static bool BorrarUsuario(int id)
        {
            
            string query = "DELETE FROM usuarios WHERE id_usuario=@id";

            using(SqlConnection connection = ConexionBD.GetConnection())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("id", id);

                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }
                catch (Exception)
                {

                    return false;
                    
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        #endregion


        #region METODO LOGIN VALIDATION

        //usuario loguedo

        public static bool IniciarSecion(string Usuario, string Contrasena)
        {
            string ContrasenaEncriptadaIngresada = Encrypt.GetSHA256(Contrasena);
            string query = "SELECT * FROM usuarios WHERE nombre=@usuario AND contrasena=@contrasena";

            using(SqlConnection conexion = ConexionBD.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@usuario", Usuario);
                command.Parameters.AddWithValue("@contrasena", ContrasenaEncriptadaIngresada);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Cache.id_usuario = reader.GetInt32(0);
                        Cache.usuario = reader.GetString(1);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
               
            }
            

           
            
            
        }

        #endregion

    }
}
