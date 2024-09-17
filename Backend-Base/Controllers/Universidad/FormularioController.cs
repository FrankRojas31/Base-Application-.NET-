using Base.API.Controllers;
using Base.Application.Services.Interfaces.Contrato;
using Base.Application.Services.Interfaces.Contrato.Universidad;
using Base.Domain.DTOs;
using Base.Domain.Entidades.Universidad;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Base.Controllers.Universidad
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormularioController : APIControllerBase<Formulario, FormularioDTO>
    {
        private readonly IFormularioService _formularioService;

        public FormularioController(IFormularioService formularioService) : base(formularioService)
        {
            _formularioService = formularioService;
        }
    }
}
