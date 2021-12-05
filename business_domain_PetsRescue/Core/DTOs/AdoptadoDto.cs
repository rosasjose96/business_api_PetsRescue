using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_domain_PetsRescue.Core.DTOs
{
    class AdoptadoDto
    {
        public IEnumerable<String> mascotas { get; set; }
        public string Usuario { get; set; }
        public string Descripción { get; set; }
    }
}
