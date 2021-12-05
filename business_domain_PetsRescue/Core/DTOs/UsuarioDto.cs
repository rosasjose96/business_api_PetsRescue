using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_domain_PetsRescue.Core.DTOs
{
    public class UsuarioLoginRequest
    {
        public string Correo { get; set; }
        public string Clave { get; set; }
    }

    public class UsuarioLoginResponse
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
    }

    public class UsuarioRegisterDto
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Clave { get; set; }
        public DateTime? FechaRegistro { get; set; }

    }

    public class UsuariosPendingResponse
    {
        public int Id { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Clave { get; set; }
        public int? Estado { get; set; }
        public DateTime? FechaUltimaActualizacion { get; set; }

    }

    public class UsuariosListResponse
    {
        public int Id { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
    }
}
