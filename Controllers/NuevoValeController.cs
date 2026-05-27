using ApiPremio.Models.DB;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiPremio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NuevoValeController : ControllerBase
    {
   

        // GET api/<NuevoValeController>/5
        [HttpGet("{nombrecliente}/{iddist}/{status}/{folio}/{monto}/{plazo}")]
        public string nuevovale(string nombrecliente, int iddist, string status, int folio, int monto, int plazo)
        {
            DataTable output = new DataTable();

            try
            {
                output = Consultas.valesvirtuales(nombrecliente, iddist, status, folio, monto, plazo);



                var jsonConver = JsonConvert.SerializeObject(output);

                return 1.ToString();
            }
            catch
            {
                return 0.ToString();
            }
           
        }

   

      

       
    }
}
