using AutoMapper;
using Base.Application.Services.Interfaces.Contrato.Personas;
using Base.Domain.Entidades.Personas;
using Base.Infraestructura.Data.Repositorios.Contrato.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Application.Services.Interfaces.Implementacion.Personas
{
    public class ProfesorServices : ServiceBase<Profesor, ProfesorDTO>, IProfesorServices
    {
        private readonly IProfesorRepository _repository;
        public ProfesorServices(IMapper mapper, IProfesorRepository repository) : base(mapper, repository)
        {
            _repository = repository;
        }
    }
}
