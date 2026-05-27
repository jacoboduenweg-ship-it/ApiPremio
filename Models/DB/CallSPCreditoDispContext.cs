using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPremio.Models.DB;

namespace ApiPremio.Models.DB
{
    public class CallSPCreditoDispContext:DbContext
    {
        public CallSPCreditoDispContext(DbContextOptions<CallSPCreditoDispContext> options):base(options)
        {

        }
        public DbSet<ApiPremio.Models.DB.Output> Output { get; set; }
    }



}
