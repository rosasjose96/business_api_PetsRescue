using AutoMapper;
using business_domain_PetsRescue.Core.DTOs;
using business_domain_PetsRescue.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_domain_PetsRescue.Infraestructure.Mapping
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Usuarios, UsuarioLoginResponse>();
            CreateMap<Usuarios, UsuariosPendingResponse>();
            CreateMap<UsuarioRegisterDto, Usuarios>();
            CreateMap<Usuarios, UsuarioRegisterDto>();

            CreateMap<UsuariosListResponse, Usuarios>();
            CreateMap<Usuarios, UsuariosListResponse>();

            CreateMap<Usuarios, IEnumerable<UsuariosListResponse>>();
            CreateMap<IEnumerable<UsuariosListResponse>, Usuarios>();

            CreateMap<MascotaListResponse, Mascotas>();
            CreateMap<Mascotas, MascotaListResponse>(); 

            CreateMap<Mascotas, IEnumerable<MascotaListResponse>>();
            CreateMap<IEnumerable<MascotaListResponse>, Mascotas>();

            CreateMap<Mascotas, MascotaRegisterRequest>();
            CreateMap<MascotaRegisterRequest, Mascotas>();
        }
    }
}
