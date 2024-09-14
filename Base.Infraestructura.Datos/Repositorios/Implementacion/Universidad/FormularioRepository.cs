using Base.Domain.Entidades.Universidad;
using Base.Infraestructura.Data.Repositories.Implementation;
using Base.Infraestructura.Data.Repositorios.Contrato.Universidad;
using Base.Infraestructura.Datos.ContextoBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Base.Infraestructura.Data.Repositorios.Implementacion.Universidad
{
    public class FormularioRepository : BaseRepository<Formulario>, IFormularioRepository
    {
        private readonly DataBaseContext _context;
        public FormularioRepository(DataBaseContext context, ClaimsPrincipal user) : base(context, user)
        {
            _context = context;
        }
    }
}
