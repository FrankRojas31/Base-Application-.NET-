using AutoMapper;
using Base.Domain.DTO.Core;
using Base.Domain.DTOs;
using Base.Domain.Entidades.Core;
using Base.Domain.Entidades.Universidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Application.Services.Mapeo
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            this.CreateMap<BaseEntity, BaseDTO>();
            this.CreateMap<FormularioDTO, Formulario>().ReverseMap();
        }
    }
}
