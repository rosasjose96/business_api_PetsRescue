using AutoMapper;
using business_domain_PetsRescue.Core.DTOs;
using business_domain_PetsRescue.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace business_api_PetsRescue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MascotaController : ControllerBase
    {
        private readonly IMascotaService _mascotaService;
        private readonly IMapper _mapper;

        public MascotaController(IMascotaService mascotaService, IMapper mapper)
        {
            _mascotaService = mascotaService;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("RegisterMascota")]
        public async Task<IActionResult> RegistrarMascota(MascotaRegisterRequest pet)
        {
            var result = await _mascotaService.InsertMascota(pet);

            if (result == false) return BadRequest("Ha ocurrido un error al momento del registro");

            return Ok("La mascota ha sido registrado exitosamente");

        }

        [HttpGet]
        [Route("Mascotas")]
        public async Task<IActionResult> ListMascotas()
        {
            var mascotas = await _mascotaService.ListMascotas();

            return Ok(mascotas);
        }
    }
}
