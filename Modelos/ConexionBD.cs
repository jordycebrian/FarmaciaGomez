using System;
using System.Data.SqlClient;

namespace Modelos
{
    public class ConexionBD
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection("Server=(local);Initial Catalog = FarmaciaGomez; integrated security = true");
            connection.Open();

            return connection;
            
        }
    }
}
