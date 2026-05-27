using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPremio.Models.DB
{
    public class ConsultaListado
    {

       public static DataTable listadoprueba(int iddist, DateTime fecha)
        {
            OutputListado output = new OutputListado();
            DataTable _consulta = new DataTable();
            
                _consulta = DBConn.ConsultaSQL($"listado_api_app {iddist}, '{fecha.ToString("yyyy-MM-dd")}'");
              
         
            return _consulta;

        }

       
    }
}
