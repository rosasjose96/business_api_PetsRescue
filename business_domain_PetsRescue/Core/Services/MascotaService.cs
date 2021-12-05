using AutoMapper;
using business_domain_PetsRescue.Core.DTOs;
using business_domain_PetsRescue.Core.Interfaces;
using business_domain_PetsRescue.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_domain_PetsRescue.Core.Services
{
    public class MascotaService : IMascotaService
    {
        private readonly IMascotaRepository _mascotaRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public MascotaService(IMascotaRepository mascotaRepository, IMapper mapper, IUsuarioRepository usuarioRepository)
        {
            _mascotaRepository = mascotaRepository;
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public async Task<bool> InsertMascota(MascotaRegisterRequest mascotaRegister)
        {
            var mascotaFound = await _mascotaRepository.GetMascotaByCodmascota(mascotaRegister.Codmascota);

            if (mascotaFound != null) return false;

            var userOwner = await _usuarioRepository.GetUsuarioByEmail(mascotaRegister.Correo);

            if (userOwner == null) return false;

            var mascota = _mapper.Map<Mascotas>(mascotaRegister);

            mascota.FechaRegistro = DateTime.Now;
            mascota.Usuario = userOwner.Nombre + " " + userOwner.Apellido;

            return await _mascotaRepository.Insert(mascota);
             
        }

        public async Task<IEnumerable<MascotaListResponse>> ListMascotas()
        {
            var mascotas = await _mascotaRepository.GetMascotas();

            var pets = _mapper.Map<IEnumerable<MascotaListResponse>>(mascotas);

            return pets;
        }
    }
}
