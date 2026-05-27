using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPremio.Entities
{
    public class DatosClientes
    {
        [Key]
        public int? idcliente { get; set; }
        public string nombre1 { get; set; }
        public string nombre2 { get; set; }
        public string appaterno { get; set; }
        public string apmaterno { get; set; }
        public string calle { get; set; }
        public string colonia { get; set; }
        public decimal? codpostal { get; set; }
        public string status { get; set; }
        public int? numdistribuidor { get; set; }
        public string telefono { get; set; }


    }
}
