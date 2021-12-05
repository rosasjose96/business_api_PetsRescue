using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_domain_PetsRescue.Core.DTOs
{
    public class MascotaPerdidaRegisterRequest
    {
        public int Codmascota { get; set; }
        public int? Estado { get; set; }
        public string Descripción { get; set; }
        public byte[] Foto { get; set; }
        public string Usuario { get; set; }
    }
}
