using business_domain_PetsRescue.Infraestructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace business_domain_PetsRescue.Core.Interfaces
{
    public interface IMascotaRepository
    {
        Task<IEnumerable<Mascotas>> GetAllMascotasByEstado(int estado);
        Task<Mascotas> GetMascotaByCodmascota(int codmascota);
        Task<Mascotas> GetMascotaById(int id);
        Task<IEnumerable<Mascotas>> GetMascotas();
        Task<bool> Insert(Mascotas mascotas);
        Task<bool> Update(Mascotas mascota);
        Task<bool> UpdateEstado(Mascotas mascota, int estado);
    }
}