using Base.API.Controllers;
using Base.Application.Services.Interfaces.Contrato.Personas;
using Base.Domain.Entidades.Personas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Base.Controllers.Personas
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : APIControllerBase<Alumno, AlumnoDTO>
    {
        private readonly IAlumnosServices _services;
        public AlumnosController(IAlumnosServices service) : base(service)
        {
            _services = service;
        }
    }
}
