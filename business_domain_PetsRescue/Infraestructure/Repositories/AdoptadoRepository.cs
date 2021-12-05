using business_domain_PetsRescue.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_domain_PetsRescue.Infraestructure.Repositories
{
    class AdoptadoRepository
    {
        private readonly PETRESCUEContext _context;

        public AdoptadoRepository(PETRESCUEContext context)
        {
            _context = context;
        }
    }
}
