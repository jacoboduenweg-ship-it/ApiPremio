using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPremio.Entities
{
    public class DatosCreditoDisp
    {
        [Key]
        public int numdistribuidor { get; set; }
        public int pagoo { get; set; }
    }
}
