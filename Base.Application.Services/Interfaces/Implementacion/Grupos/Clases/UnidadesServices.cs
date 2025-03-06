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
    public class UnidadesServices : ServiceBase<Unidades, UnidadesDTO>, IUnidadesServices
    {
        private readonly IUnidadesRepository _repository;
        public UnidadesServices(IMapper mapper, IUnidadesRepository repository) : base(mapper, repository)
        {
            _repository = repository;
        }
    }
}
