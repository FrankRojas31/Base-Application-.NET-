using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Base.Domain.Entidades.Grupos.Clases;
using Base.Infraestructura.Data.Repositories.Implementation;
using Base.Infraestructura.Data.Repositorios.Contrato.Grupos.Clases;
using Base.Infraestructura.Datos.ContextoBD;

namespace Base.Infraestructura.Data.Repositorios.Implementacion.Grupos.Clases
{
    public class UnidadesMateriasRepository : BaseRepository<UnidadesMaterias>, IUnidadesMateriasRepository
    {
        private readonly DataBaseContext _context;

        public UnidadesMateriasRepository(DataBaseContext context, ClaimsPrincipal user) : base(context, user)
        {
            _context = context;
        }
    }
}
