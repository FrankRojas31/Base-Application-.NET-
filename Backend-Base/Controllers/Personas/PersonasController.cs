using Base.API.Controllers;
using Base.Application.Services.Interfaces.Contrato.Personas;
using Base.Domain.Entidades.Personas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Base.Controllers.Personas
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : APIControllerBase<Persona, PersonaDTO>
    {
        private readonly IPersonaServices _services;
        public PersonasController(IPersonaServices service) : base(service)
        {
            _services = service;
        }
    }
}
