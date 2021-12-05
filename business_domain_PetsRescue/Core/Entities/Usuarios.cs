using System;
using System.Collections.Generic;

#nullable disable

namespace business_domain_PetsRescue.Infraestructure.Data
{
    public partial class Usuarios
    {
        public int Id { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Clave { get; set; }
        public int? Estado { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaUltimaActualizacion { get; set; }
    }
}
