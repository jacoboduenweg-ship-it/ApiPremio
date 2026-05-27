using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ApiPremio.Contents;
using ApiPremio.Entities;
using ApiPremio.Models.DB;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiPremio.Controllers
{
    [Route("api/[controller]")]
    public class IdPagareController : Controller
    {




        // GET api/<controller>/5
        // GET api/<InfoPagare2Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            DataTable output = new DataTable();


            output = Consultas.idpagare(id);



            var jsonConver = JsonConvert.SerializeObject(output);

            return jsonConver;
        }
    }
}
