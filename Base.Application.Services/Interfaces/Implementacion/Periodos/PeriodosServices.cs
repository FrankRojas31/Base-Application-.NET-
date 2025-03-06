using AutoMapper;
using Base.Application.Services.Interfaces.Contrato.Periodos;
using Base.Domain.Entidades.Periodos;
using Base.Infraestructura.Data.Repositorios.Contrato;
using Base.Infraestructura.Data.Repositorios.Contrato.Periodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Application.Services.Interfaces.Implementacion.Periodos
{
    public class PeriodosServices : ServiceBase<Periodo, PeriodoDTO>, IPeriodosServices
    {
        private readonly IPeriodosRepository _repository;
        public PeriodosServices(IMapper mapper, IPeriodosRepository repository) : base(mapper, repository)
        {
            _repository = repository;
        }
    }
}
