using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPremio.Entities
{
    public class DatosAvisos
    {
        [Key]

        public int idaviso { get; set; }
        public string aviso { get; set; }
        public string titulo { get; set; }
        public DateTime fecha { get; set;  }
        public DateTime fechavencimiento { get; set; }
        public int? idusuario { get; set; }
        public string status { get; set; }

    }
}
