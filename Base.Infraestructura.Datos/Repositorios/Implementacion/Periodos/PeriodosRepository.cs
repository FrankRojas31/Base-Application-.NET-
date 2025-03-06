using Base.Domain.Entidades.Periodos;
using Base.Infraestructura.Data.Repositories.Implementation;
using Base.Infraestructura.Data.Repositorios.Contrato.Periodos;
using Base.Infraestructura.Datos.ContextoBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Base.Infraestructura.Data.Repositorios.Implementacion.Periodos
{
    public class PeriodosRepository : BaseRepository<Periodo>, IPeriodosRepository
    {
        private readonly DataBaseContext _context;

        public PeriodosRepository(DataBaseContext context, ClaimsPrincipal user) : base(context, user)
        {
            _context = context;
        }
    }
}