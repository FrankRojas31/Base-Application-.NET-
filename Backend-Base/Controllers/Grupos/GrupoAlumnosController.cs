using Base.API.Controllers;
using Base.Application.Services.Interfaces.Contrato.Grupos;
using Base.Domain.Entidades.Grupos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Base.Controllers.Grupos
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoAlumnosController : APIControllerBase<GruposAlumnos, GruposAlumnosDTO>
    {
        private readonly IGruposAlumnosServices _services;
        public GrupoAlumnosController(IGruposAlumnosServices service) : base(service)
        {
            _services = service;
        }
    }
}
