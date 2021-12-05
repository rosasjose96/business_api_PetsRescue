using System;
using System.Collections.Generic;

#nullable disable

namespace business_domain_PetsRescue.Infraestructure.Data
{
    public partial class Mascotas
    {
        public int Id { get; set; }
        public string Codmascota { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public string Correo { get; set; }
        public string Color { get; set; }
        public string Edad { get; set; }
        public int Estado { get; set; }
        public string Descripción { get; set; }
        public byte[] Foto { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaUltimaActualizacion { get; set; }
        public string Usuario { get; set; }
        public string Propietario { get; set; }
    }
}
