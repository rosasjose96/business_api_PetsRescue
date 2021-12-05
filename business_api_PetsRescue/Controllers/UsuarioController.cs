using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business_domain_PetsRescue.Core.DTOs;
using AutoMapper;
using System.Net.Http;
using System.Net;
using business_domain_PetsRescue.Core.Interfaces;

namespace business_api_PetsRescue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuariosService;
        private readonly IMapper _mapper;

        public UsuarioController(IUsuarioService usuariosService, IMapper mapper)
        {
            _usuariosService = usuariosService;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("login/user")]
        public async Task<IActionResult> Login(UsuarioLoginRequest usr)
        {
            var usrExist = await _usuariosService.ValidateUserLogin(usr);

            if (usrExist == 0) return NotFound();

            if (usrExist == 1) return Unauthorized("Usted aún no ha sido aprobado");

            var userFound = await _usuariosService.GetUserLogged(usr.Correo);

            return Ok(userFound);
        }

        [HttpPost]
        [Route("RegisterUser")]
        public async Task<IActionResult> RegistrarUsuario(UsuarioRegisterDto usr)
        {
            string mensaje;
            var result = await _usuariosService.InsertUser(usr);

            if (result == false) return BadRequest("Error. El correo ingresado ya existe");

            return Ok("El usuario ha sido registrado exitosamente");

        }

        [HttpGet]
        [Route("Users")]
        public async Task<IActionResult> ListUsers()
        {
            var usuarios = await _usuariosService.ListUsers();

            return Ok(usuarios);
        }

        [HttpGet]
        [Route("Users/pending/{estado}")]
        public async Task<IActionResult> ListUsersPending(int estado)
        {
            var usuarios = await _usuariosService.ListUsersPending(estado);

            return Ok(usuarios);
        }

        [HttpPut]
        [Route("Users/update/{id}")]
        public async Task<IActionResult> UpdateUserState(int id)
        {
            var usuario = await _usuariosService.UpdateEstado(id);

            if (usuario == false) NotFound("Error. No se ha encontrado el usuario con el id indicado");
            return Ok("Usuario actualizado correctamente");
        }
    }

    
}
