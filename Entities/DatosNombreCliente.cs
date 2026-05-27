using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPremio.Entities
{
    public class DatosNombreCliente
    {
        [Key]
        public int idcliente { get; set; }
        public string nombre1 { get; set; }
        public string nombre2 { get; set; }
        public string appaterno { get; set; }
        public string apmaterno { get; set; }
    }
}
