using business_domain_PetsRescue.Infraestructure.Data;
using business_domain_PetsRescue.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_domain_PetsRescue.Infraestructure.Repositories
{
    public class MascotaRepository : IMascotaRepository
    {
        private readonly PETRESCUEContext _context;

        public MascotaRepository(PETRESCUEContext context)
        {
            _context = context;
        }

        public async Task<Mascotas> GetMascotaByCodmascota(int codmascota)
        {
            return await _context.Mascotas.Where(x => x.Codmascota.Equals(codmascota)).FirstOrDefaultAsync();
        }

        public async Task<Mascotas> GetMascotaById(int id)
        {
            return await _context.Mascotas.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Mascotas>> GetMascotas()
        {
            return await _context.Mascotas.ToListAsync();
        }

        public async Task<bool> Insert(Mascotas mascotas)
        {
            _context.Mascotas.Add(mascotas);
            int countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Update(Mascotas mascota)
        {
            var mascotasNow = await _context.Mascotas.FindAsync(mascota.Id);
            mascotasNow.Edad = mascota.Edad;
            mascotasNow.Nombre = mascota.Nombre;
            mascotasNow.Raza = mascota.Raza;
            mascotasNow.Descripción = mascota.Descripción;
            mascotasNow.Estado = mascota.Estado;
            mascotasNow.Usuario = mascota.Usuario;

            int countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> UpdateEstado(Mascotas mascota, int estado)
        {
            var mascotasNow = await _context.Mascotas.FindAsync(mascota.Id);
            mascotasNow.Estado = estado;

            int countRows = await _context.SaveChangesAsync();

            return (countRows > 0);
        }

        public async Task<IEnumerable<Mascotas>> GetAllMascotasByEstado(int estado)
        {
            return await _context.Mascotas.Where(x => x.Estado == estado).ToListAsync();
        }
    }
}
