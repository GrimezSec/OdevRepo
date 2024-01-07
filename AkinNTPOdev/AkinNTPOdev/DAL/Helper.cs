using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AkinNTPOdev.OdevModel
{
    public class Helper : IDisposable
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private string connectionString;

        public Helper()
        {
            connectionString = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
        }

        public int ExecuteNonQuery(string cmdText, SqlParameter[] parameters = null)
        {
            using (cn = new SqlConnection(connectionString))
            {
                using (cmd = new SqlCommand(cmdText, cn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    cn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public SqlDataReader ExecuteReader(string cmdText, SqlParameter[] parameters = null)
        {
            cn = new SqlConnection(connectionString);
            cmd = new SqlCommand(cmdText, cn);

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            cn.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public void Dispose()
        {
            if (cn != null && cn.State != ConnectionState.Closed)
            {
                cn.Close();
            }
            cn?.Dispose();
            cmd?.Dispose();
        }
    }
}
