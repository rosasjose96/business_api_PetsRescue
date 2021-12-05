using business_domain_PetsRescue.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace business_domain_PetsRescue.Core.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioLoginResponse> GetUserLogged(string correo);
        Task<int> ValidateUserLogin(UsuarioLoginRequest user);

        Task<bool> InsertUser(UsuarioRegisterDto user);
        Task<bool> UpdateEstado(int id);
        Task<IEnumerable<UsuariosListResponse>> ListUsers();
        Task<IEnumerable<UsuariosListResponse>> ListUsersPending(int estado);
    }
}