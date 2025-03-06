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
    public class UnidadesMateriasController : APIControllerBase<UnidadesMaterias, UnidadesMateriasDTO>
    {
        private readonly IUnidadesMateriasServices _services;
        public UnidadesMateriasController(IUnidadesMateriasServices service) : base(service)
        {
            _services = service;
        }
    }
}
