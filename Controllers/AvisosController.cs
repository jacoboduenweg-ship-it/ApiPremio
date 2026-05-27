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
    public class AvisosController : ControllerBase
    {
        private readonly AppDbContext context;
        public AvisosController(AppDbContext context)
        {
            this.context = context;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string avisos(int id)
        {
            DataTable output = new DataTable();


            output = Consultas.AvisosIndividuales(id);



            var jsonConver = JsonConvert.SerializeObject(output);

            return jsonConver;
        }

      
    }
}
