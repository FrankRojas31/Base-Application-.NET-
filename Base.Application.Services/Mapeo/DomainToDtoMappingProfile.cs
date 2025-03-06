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
            this.CreateMap<Grupo, GruposDTO>();
            this.CreateMap<GruposAlumnos, GruposAlumnosDTO>();
            this.CreateMap<GruposPeriodos, GruposPeriodosDTO>();
            this.CreateMap<Periodo, PeriodoDTO>();
            this.CreateMap<Profesor, ProfesorDTO>();
            this.CreateMap<Alumno, AlumnoDTO>();
            this.CreateMap<Materias, MateriasDTO>();
            this.CreateMap<Unidades, UnidadesDTO>();
            this.CreateMap<UnidadesMaterias, UnidadesMateriasDTO>();
            this.CreateMap<Persona, PersonaDTO>();

        }
    }
}
