using AutoMapper;
using Base.Domain.DTO.Core;
using Base.Domain.DTOs.Grupos.Clases;
using Base.Domain.Entidades.Core;
using Base.Domain.Entidades.Grupos;
using Base.Domain.Entidades.Grupos.Clases;
using Base.Domain.Entidades.Periodos;
using Base.Domain.Entidades.Personas;
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
            this.CreateMap<Grupo, GruposDTO>().ReverseMap();
            this.CreateMap<GruposAlumnos, GruposAlumnosDTO>().ReverseMap();
            this.CreateMap<GruposPeriodos, GruposPeriodosDTO>().ReverseMap();
            this.CreateMap<Periodo, PeriodoDTO>().ReverseMap();
            this.CreateMap<Profesor, ProfesorDTO>().ReverseMap();
            this.CreateMap<Alumno, AlumnoDTO>().ReverseMap();
            this.CreateMap<Materias, MateriasDTO>().ReverseMap();
            this.CreateMap<Unidades, UnidadesDTO>().ReverseMap();
            this.CreateMap<UnidadesMaterias, UnidadesMateriasDTO>().ReverseMap();
            this.CreateMap<Persona, PersonaDTO>().ReverseMap();

        }
    }
}
