using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPremio.Contents;
using ApiPremio.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiPremio.Controllers
{
    [Route("api/[controller]")]
    public class InfoPagareController : Controller
    {
        private readonly AppDbContext context;
        public InfoPagareController(AppDbContext context)
        {
            this.context = context;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<DatosVales> Get()
        {
            return context.pagares.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public DatosVales Get(int id)
        {
            var datos = context.pagares.FirstOrDefault(p => p.idpagare == id);
            return datos;
        }



        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
