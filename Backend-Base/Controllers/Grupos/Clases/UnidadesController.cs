using Base.API.Controllers;
using Base.Application.Services.Interfaces.Contrato.Grupos.Clases;
using Base.Domain.DTOs.Grupos.Clases;
using Base.Domain.Entidades.Grupos.Clases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Base.Controllers.Grupos.Clases
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnidadesController : APIControllerBase<Unidades, UnidadesDTO>
    {
        private readonly IUnidadesServices _services;
        public UnidadesController(IUnidadesServices service) : base(service)
        {
            _services = service;
        }
    }
}
