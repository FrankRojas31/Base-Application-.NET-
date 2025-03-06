using Base.API.Controllers;
using Base.Application.Services.Interfaces.Contrato.Periodos;
using Base.Domain.Entidades.Periodos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Base.Controllers.Periodos
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeriodosController : APIControllerBase<Periodo, PeriodoDTO>
    {
        private readonly IPeriodosServices _services;
        public PeriodosController(IPeriodosServices service) : base(service)
        {
            _services = service;
        }
    }
}
