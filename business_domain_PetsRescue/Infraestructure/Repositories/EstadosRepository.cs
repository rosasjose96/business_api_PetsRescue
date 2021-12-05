using business_domain_PetsRescue.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_domain_PetsRescue.Infraestructure.Repositories
{
    class EstadosRepository
    {
        private readonly PETRESCUEContext _context;

        public EstadosRepository(PETRESCUEContext context)
        {
            _context = context;
        }
    }
}
