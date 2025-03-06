using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using Base.Domain.Entidades.Grupos;
using Base.Infraestructura.Datos.ContextoBD;
using Base.Infraestructura.Data.Repositories.Implementation;
using Base.Infraestructura.Data.Repositorios.Contrato.Grupos;

namespace Base.Infraestructura.Data.Repositorios.Implementacion.Grupos
{
    public class GruposRepository : BaseRepository<Grupo>, IGruposRepository
    {
        private readonly DataBaseContext _context;

        public GruposRepository(DataBaseContext context, ClaimsPrincipal user) : base(context, user)
        {
            _context = context;
        }
    }
}
