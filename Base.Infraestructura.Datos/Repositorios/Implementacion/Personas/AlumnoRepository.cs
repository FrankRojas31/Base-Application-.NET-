using Base.Domain.Entidades.Personas;
using Base.Infraestructura.Data.Repositories.Implementation;
using Base.Infraestructura.Data.Repositorios.Contrato.Personas;
using Base.Infraestructura.Datos.ContextoBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Base.Infraestructura.Data.Repositorios.Implementacion.Personas
{
    public class AlumnoRepository : BaseRepository<Alumno>, IAlumnoRepository
    {
        private readonly DataBaseContext _context;

        public AlumnoRepository(DataBaseContext context, ClaimsPrincipal user) : base(context, user)
        {
            _context = context;
        }
    }
}
