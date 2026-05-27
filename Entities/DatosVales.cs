using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPremio.Entities
{
    public class DatosVales
    {
        [Key]
        public int numpagare { get; set; }
        public int idpagare { get; set; }
        public Int16 idsucursal { get; set; }
        public int idcliente {get; set; }
        public DateTime fecha { get; set; }
        public DateTime vencimiento { get; set; }
        public string status { get; set; }

    }
}
