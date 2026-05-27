using ApiPremio.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPremio.Contents
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Usuarios> usuariosapp { get; set; }
        public DbSet<DatosClientes> clientes { get; set; }
        public DbSet<DatosVales> pagares { get; set; }
        public DbSet<DatoIdPagare> vales { get; set; }
        public DbSet<DatosAvisos> avisos { get; set; }
        public DbSet<DatosCreditoDisp> creditodisp_api_app { get; set; }
        
    }
}
