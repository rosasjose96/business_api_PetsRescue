using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_domain_PetsRescue.Core.DTOs
{
    public class MascotaDetailResponse
    {
        public int Codmascota { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public string Color { get; set; }
        public string Edad { get; set; }
        public int Estado { get; set; }
        public string Descripción { get; set; }
        public byte[] Foto { get; set; }
    }

    public class MascotaRegisterRequest
    {
        public int Codmascota { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public string Correo { get; set; }
        public string Color { get; set; }
        public string Edad { get; set; }
        public string Descripción { get; set; }
    }

    public class MascotaListResponse
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public byte[] Foto { get; set; }
    }

    public class MascotaDetailRequest
    {
        public int Id { get; set; }
    }

}
