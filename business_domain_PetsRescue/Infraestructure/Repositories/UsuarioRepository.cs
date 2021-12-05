using business_domain_PetsRescue.Core.DTOs;
using business_domain_PetsRescue.Core.Interfaces;
using business_domain_PetsRescue.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_domain_PetsRescue.Infraestructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly PETRESCUEContext _context;

        public UsuarioRepository(PETRESCUEContext context)
        {
            _context = context;
        }

        public async Task<Usuarios> GetUsuarioByEmail(String correo)
        {
            return await _context.Usuarios.Where(x => x.Correo == correo).FirstOrDefaultAsync();
        }

        public async Task<Usuarios> GetUsuarioById(int id)
        {
            return await _context.Usuarios.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Usuarios>> GetUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<bool> Insert(Usuarios usuario)
        {
            _context.Usuarios.Add(usuario);
            int countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Update(Usuarios usuario)
        {
            var usuarioNow = await _context.Usuarios.FindAsync(usuario.Id);
            usuarioNow.Telefono = usuario.Telefono;
            usuarioNow.Nombre = usuario.Nombre;
            usuarioNow.Apellido = usuario.Apellido;
            usuarioNow.Telefono = usuario.Telefono;
            usuarioNow.Estado = usuario.Estado;

            int countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> UpdateEstado(Usuarios usuario)
        {
            var usuarioNow = await _context.Usuarios.FindAsync(usuario.Id);
            usuarioNow.Estado = 2;

            int countRows = await _context.SaveChangesAsync();

            return (countRows > 0);
        }

        public async Task<IEnumerable<Usuarios>> GetAllUsuariosByEstado(int estado)
        {
            return await _context.Usuarios.Where(x => x.Estado == estado).ToListAsync();
        }

        
    }
}
