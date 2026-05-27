using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiPremio.Models.DB;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;

namespace ApiPremio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListadosController : ControllerBase
    {
        private readonly ListadoContext _context;

        public ListadosController(ListadoContext context)
        {
            _context = context;
        }

        // GET: api/Listados/5
        [HttpGet("{id}/{fecha}")]
        public string Listados(int id, DateTime fecha)
        {
            //var datos = String.Format("listado_api_app {0}, '{1}'", id, fecha.ToString("yyyy-MM-dd"));

            //return _context.OutputListado.FromSql(datos).ToArray();

            DataTable output = new DataTable();

           
            output = ConsultaListado.listadoprueba(id, fecha);

         

            var jsonConver = JsonConvert.SerializeObject(output);

            return jsonConver.ToString();

        }





    }
}