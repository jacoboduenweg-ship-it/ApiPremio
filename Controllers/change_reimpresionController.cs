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
    public class change_reimpresionController : ControllerBase
    {
     

        // GET api/<change_reimpresionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            DataTable output = new DataTable();


            output = Models.DB.Consultas.change_reimpresion(id);



            var jsonConver = JsonConvert.SerializeObject(output);

            return jsonConver;
        }

        }
    }
