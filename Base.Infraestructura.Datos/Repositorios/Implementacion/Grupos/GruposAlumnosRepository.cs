using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Base.Domain.Entidades.Grupos;
using Base.Infraestructura.Data.Repositories.Implementation;
using Base.Infraestructura.Data.Repositorios.Contrato.Grupos;
using Base.Infraestructura.Datos.ContextoBD;

namespace Base.Infraestructura.Data.Repositorios.Implementacion.Grupos
{
    public class GruposAlumnosRepository : BaseRepository<GruposAlumnos>, IGruposAlumnosRepository
    {
        private readonly DataBaseContext _context;

        public GruposAlumnosRepository(DataBaseContext context, ClaimsPrincipal user) : base(context, user)
        {
            _context = context;
        }
    }
}
