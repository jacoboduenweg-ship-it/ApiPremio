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
    public class modificarcontraController : ControllerBase
    {
   
        // GET api/<modificarcontraController>/5
        [HttpGet("{id}/{contra}")]
        public string Get(int id, string contra)
        {
            DataTable output = new DataTable();


            output = Consultas.actualizarcontra(id, contra);



            var jsonConver = JsonConvert.SerializeObject(output);

            return jsonConver;
        }
    }
}
