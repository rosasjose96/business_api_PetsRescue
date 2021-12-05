using System;
using System.Collections.Generic;

#nullable disable

namespace business_domain_PetsRescue.Infraestructure.Data
{
    public partial class MascotasPerdidas
    {
        public int Id { get; set; }
        public int Codmascota { get; set; }
        public int? Estado { get; set; }
        public string Descripción { get; set; }
        public byte[] Foto { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaUltimaActualizacion { get; set; }
        public string Usuario { get; set; }
        public string Informador { get; set; }
    }
}
