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
    public class UsuariosController : Controller
    {
        private readonly AppDbContext context;

        public UsuariosController(AppDbContext context)
        {
            this.context = context;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Usuarios> Get()
        {
            return context.usuariosapp.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Usuarios Get(string id, string contra)
        {
            var usuario = context.usuariosapp.FirstOrDefault(p=>p.usuario==id);
            var contra2  = context.usuariosapp.FirstOrDefault(p => p.contrasena == contra);
            return usuario;
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
