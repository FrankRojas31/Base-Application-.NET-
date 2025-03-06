using AutoMapper;
using Base.Application.Services.Interfaces.Contrato.Grupos.Clases;
using Base.Domain.DTOs.Grupos.Clases;
using Base.Domain.Entidades.Grupos.Clases;
using Base.Infraestructura.Data.Repositorios.Contrato;
using Base.Infraestructura.Data.Repositorios.Contrato.Grupos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Application.Services.Interfaces.Implementacion.Grupos.Clases
{
    public class MateriasServices : ServiceBase<Materias, MateriasDTO>, IMateriasServices
    {
        private readonly IMateriasRepository _materiasRepository;
        public MateriasServices(IMapper mapper, IMateriasRepository repository) : base(mapper, repository)
        {
            _materiasRepository = repository;
        }
    }
}
