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
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public async Task<int> ValidateUserLogin(UsuarioLoginRequest user)
        {
            var usuario = await _usuarioRepository.GetUsuarioByEmail(user.Correo);
            if (usuario == null || usuario.Clave != user.Clave) return 0;
            return (int)usuario.Estado;
        }

        public async Task<UsuarioLoginResponse> GetUserLogged(string correo)
        {
            var usuario = await _usuarioRepository.GetUsuarioByEmail(correo);

            return _mapper.Map<UsuarioLoginResponse>(usuario);
        }

        public async Task<bool> InsertUser(UsuarioRegisterDto user)
        {
            var emailExist = await _usuarioRepository.GetUsuarioByEmail(user.Correo);
            if (emailExist != null) return false;
            var usuario = _mapper.Map<Usuarios>(user);
            usuario.Estado = 1;
            return await _usuarioRepository.Insert(usuario);
        }

        public async Task<IEnumerable<UsuariosListResponse>> ListUsers()
        {
            var usuarios = await _usuarioRepository.GetUsuarios();

            var users = _mapper.Map<IEnumerable<UsuariosListResponse>>(usuarios);

            return users;
        }

        public async Task<IEnumerable<UsuariosListResponse>> ListUsersPending(int estado)
        {
            var usuarios = await _usuarioRepository.GetAllUsuariosByEstado(estado);

            var users = _mapper.Map<IEnumerable<UsuariosListResponse>>(usuarios);

            return users;
        }

        public async Task<bool> UpdateEstado(int id)
        {
            var userFound = await _usuarioRepository.GetUsuarioById(id);
            if (userFound == null) return false;
            return await _usuarioRepository.UpdateEstado(userFound);
        }
    }
}
