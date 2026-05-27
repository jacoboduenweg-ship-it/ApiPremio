using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPremio.Models.DB;

namespace ApiPremio.Models.DB
{
    public class ListadoContext : DbContext
    {
            public ListadoContext(DbContextOptions<ListadoContext> options) : base(options)
            {

            }
            public DbSet<ApiPremio.Models.DB.OutputListado> OutputListado { get; set; }
        
    }
}
