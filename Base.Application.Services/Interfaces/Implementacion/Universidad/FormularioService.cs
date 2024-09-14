using AutoMapper;
using Base.Application.Services.Interfaces.Contrato.Universidad;
using Base.Domain.DTOs;
using Base.Domain.Entidades.Universidad;
using Base.Infraestructura.Data.Repositorios.Contrato;
using Base.Infraestructura.Data.Repositorios.Contrato.Universidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Application.Services.Interfaces.Implementacion.Universidad
{
    public class FormularioService : ServiceBase<Formulario, FormularioDTO>, IFormularioService
    {
        private readonly IFormularioRepository _formularioRepository;
        public FormularioService(IMapper mapper, IFormularioRepository formularioRepository) : base(mapper, formularioRepository)
        {
            _formularioRepository = formularioRepository;
        }
    }
}
