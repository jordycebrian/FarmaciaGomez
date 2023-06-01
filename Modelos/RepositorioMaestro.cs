using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public abstract class RepositorioMaestro
    {
        public List<SqlParameter> parameters;


        protected void ExecuteNonQuery(string TransactSql)
        {
            using(var conexion = ConexionBD.GetConnection())
            {
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = TransactSql;
                    command.CommandType = CommandType.Text;
                    foreach(SqlParameter item in parameters)
                    {
                        command.Parameters.Add(item);
                    }
                    command.ExecuteNonQuery();
                    parameters.Clear();
                }
            }
        }


        protected DataTable ExecuteReader(string TransactSql)
        {
            using(SqlConnection conexion = ConexionBD.GetConnection())
            {
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = TransactSql;
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    using(var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }

                }
            }
        }
    }
}
