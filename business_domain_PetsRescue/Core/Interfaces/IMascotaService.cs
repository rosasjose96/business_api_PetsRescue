using business_domain_PetsRescue.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace business_domain_PetsRescue.Core.Interfaces
{
    public interface IMascotaService
    {
        Task<bool> InsertMascota(MascotaRegisterRequest mascotaRegister);
        Task<IEnumerable<MascotaListResponse>> ListMascotas();
    }
}