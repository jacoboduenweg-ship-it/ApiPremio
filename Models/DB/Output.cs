using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPremio.Models.DB
{
    public partial class Output
    {
        [Key]
        public decimal pagoo { get; set; }
    }
}
