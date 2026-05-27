using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiPremio.Models.DB
{
    public class OutputListado
    {
        [Key]

        public DateTime fechapago { get; set; }
        public string folio { get; set; }
        public decimal montoprestamo { get; set; }
        public decimal adeudo { get; set; }
        public string nombcomp { get; set; }
        public Int16 numquincenas { get; set; }
        public Int16 numpago { get; set; }
        public decimal pago { get; set; }
    }

    
}
