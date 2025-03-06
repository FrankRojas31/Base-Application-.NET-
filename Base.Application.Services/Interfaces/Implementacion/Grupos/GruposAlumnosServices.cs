using AutoMapper;
using Base.Application.Services.Interfaces.Contrato.Grupos;
using Base.Domain.Entidades.Grupos;
using Base.Infraestructura.Data.Repositorios.Contrato.Grupos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Application.Services.Interfaces.Implementacion.Grupos
{
    public class GruposAlumnosServices : ServiceBase<GruposAlumnos, GruposAlumnosDTO>, IGruposAlumnosServices
    {
        private readonly IGruposAlumnosRepository _repository;
        public GruposAlumnosServices(IMapper mapper, IGruposAlumnosRepository repository) : base(mapper, repository)
        {
            _repository = repository;
        }
    }
}
