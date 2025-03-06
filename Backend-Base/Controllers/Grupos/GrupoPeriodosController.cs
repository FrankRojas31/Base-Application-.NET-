using Base.API.Controllers;
using Base.Application.Services.Interfaces.Contrato.Grupos;
using Base.Application.Services.Interfaces.Implementacion.Grupos;
using Base.Domain.Entidades.Grupos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Base.Controllers.Grupos
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoPeriodosController : APIControllerBase<GruposPeriodos, GruposPeriodosDTO>
    {
        private readonly IGrupoPeriodosServices _services;
        public GrupoPeriodosController(IGrupoPeriodosServices service) : base(service)
        {
            _services = service;
        }
    }
}
