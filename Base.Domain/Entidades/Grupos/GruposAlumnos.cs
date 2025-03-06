using Base.Domain.Entidades.Core;
using Base.Domain.Entidades.Personas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.Domain.Entidades.Grupos
{
    [Table("Tbl_GruposAlumnos")]
    public class GruposAlumnos : BaseEntity
    {
        [ForeignKey(nameof(Grupo))]
        public int IdGrupo { get; set; }
        public virtual Grupo Grupo { get; set; }

        [ForeignKey(nameof(Alumno))]
        public int IdAlumno { get; set; }
        public virtual Alumno Alumno { get; set; }
    }
}
