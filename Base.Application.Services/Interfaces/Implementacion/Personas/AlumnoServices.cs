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
    public class AlumnoServices : ServiceBase<Alumno, AlumnoDTO>, IAlumnosServices
    {
        private readonly IAlumnoRepository _repository;
        public AlumnoServices(IMapper mapper, IAlumnoRepository repository) : base(mapper, repository)
        {
            _repository = repository;
        }
    }
}
