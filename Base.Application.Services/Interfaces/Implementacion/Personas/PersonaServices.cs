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
    public class PersonaServices : ServiceBase<Persona, PersonaDTO>, IPersonaServices
    {
        private readonly IPersonaRepository _repository;
        public PersonaServices(IMapper mapper, IPersonaRepository repository) : base(mapper, repository)
        {
            _repository = repository;
        }
    }
}
