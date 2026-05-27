using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiPremio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class get_reimpresionController : ControllerBase
    {
        // GET: api/<get_reimpresionController>
     

        // GET api/<get_reimpresionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            DataTable output = new DataTable();


            output = Models.DB.Consultas.get_reimpresion(id);



            var jsonConver = JsonConvert.SerializeObject(output);

            return jsonConver;
        }

      
    }
}
