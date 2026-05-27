using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ApiPremio
{
    public class DBConn
    {
        public static SqlConnection ConexionSQL()
        {
            SqlConnection conectString = new SqlConnection(@"Server=169.197.183.51;Database=RENTIA;User Id=vales;Password=Mz374wjsRvMp;");

         
            return conectString;
        }

        public static DataTable ConsultaSQL(string query)
        {
            DataTable _Consulta = new DataTable();
            SqlConnection conn = new SqlConnection();
            conn = DBConn.ConexionSQL();

            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
                else
                {
                    conn.Open();
                }
                _Consulta.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return _Consulta;
        }
 
       
    }
}
