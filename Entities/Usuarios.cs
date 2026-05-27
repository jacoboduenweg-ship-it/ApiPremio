using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPremio.Entities
{
    public class Usuarios
    {
        [Key]
        public int idusuario { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public int iddistribuidor { get; set; }
    }
}
