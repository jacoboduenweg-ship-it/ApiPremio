using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPremio.Entities
{
    public class DatoIdPagare
    {
        [Key]
        public string folio { get; set; }
        public int idpagare { get; set; }
    }
}
