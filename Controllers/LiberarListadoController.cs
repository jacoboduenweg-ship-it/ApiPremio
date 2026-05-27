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
    public class LiberarListadoController : ControllerBase
    {
     
        // GET api/<LiberarListadoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            DataTable output = new DataTable();


            output = Consultas.LiberarListado(id);



            var jsonConver = JsonConvert.SerializeObject(output);

            return jsonConver;
        }

    }
}
