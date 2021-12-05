using business_domain_PetsRescue.Infraestructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace business_domain_PetsRescue.Core.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuarios>> GetAllUsuariosByEstado(int estado);
        Task<Usuarios> GetUsuarioByEmail(string correo);
        Task<Usuarios> GetUsuarioById(int id);
        Task<IEnumerable<Usuarios>> GetUsuarios();
        Task<bool> Insert(Usuarios usuario);
        Task<bool> Update(Usuarios usuario);
        Task<bool> UpdateEstado(Usuarios usuario);
    }
}