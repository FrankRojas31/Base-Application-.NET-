using AutoMapper;
using Base.Application.Services.Interfaces.Contrato.Grupos;
using Base.Domain.Entidades.Grupos;
using Base.Infraestructura.Data.Repositorios.Contrato;
using Base.Infraestructura.Data.Repositorios.Contrato.Grupos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Application.Services.Interfaces.Implementacion.Grupos
{
    public class GruposPeriodosServices : ServiceBase<GruposPeriodos, GruposPeriodosDTO>, IGrupoPeriodosServices
    {
        private readonly IGruposPeriodosRepository _repository;
        public GruposPeriodosServices(IMapper mapper, IGruposPeriodosRepository repository) : base(mapper, repository)
        {
            _repository = repository;
        }
    }
}
