using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Base.Domain.Entidades.Grupos;
using Base.Infraestructura.Data.Repositories.Implementation;
using Base.Infraestructura.Data.Repositorios.Contrato.Grupos;
using Base.Infraestructura.Datos.ContextoBD;

namespace Base.Infraestructura.Data.Repositorios.Implementacion.Grupos
{
    public class GruposPeriodosRepository : BaseRepository<GruposPeriodos>, IGruposPeriodosRepository
    {
        private readonly DataBaseContext _context;

        public GruposPeriodosRepository(DataBaseContext context, ClaimsPrincipal user) : base(context, user)
        {
            _context = context;
        }
    }
}
