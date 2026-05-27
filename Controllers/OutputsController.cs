using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiPremio.Models.DB;
using Newtonsoft.Json;
using System.Data;

namespace ApiPremio
{
    [Route("api/[controller]")]
    [ApiController]
    public class OutputsController : ControllerBase
    {
        private readonly CallSPCreditoDispContext _context;

        public OutputsController(CallSPCreditoDispContext context)
        {
            _context = context;
        }

        public object OutputListadoss { get; private set; }

        // GET: api/Outputs
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Output>>> GetOutput(Input input)
        //{
        //    //string datos = "exec creditodisp_api_app " + "@numdist = " + input.numdistribuidor;

        //    //return 
        //}

        // GET: api/Outputs/5
        [HttpGet("{id}")]
        public string avisos(int id)
        {
            DataTable output = new DataTable();


            output = Consultas.saldo(id);



            var jsonConver = JsonConvert.SerializeObject(output);

            return jsonConver;



        }





    }
}