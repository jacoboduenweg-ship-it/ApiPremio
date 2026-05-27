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
    public class verificarclientenuevo2Controller : ControllerBase
    {
        [HttpGet("{nombre1}/{appaterno}/{apmaterno}")]
        public string Get(string nombre1, string appaterno, string apmaterno)
        {
            DataTable output = new DataTable();


            output = Consultas.consultacliente2(nombre1, appaterno, apmaterno);



            var jsonConver = JsonConvert.SerializeObject(output);

            if (jsonConver.Length == 2)
            {
                return 0.ToString();
            }
            else
            {
                return jsonConver;
            }





        }
    }
}
