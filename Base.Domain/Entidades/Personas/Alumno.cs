using Base.Domain.Entidades.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Domain.Entidades.Personas
{
    [Table("Tbl_Alumnos")]
    public class Alumno : BaseEntity
    {
        public string Nombres { get; set; }
        public string Apellido_Materno { get; set; }
        public string Apellido_Paterno { get; set; }
        public int Matricula { get; set; }

        //[ForeignKey(nameof(Persona))]
        //public int? IdPersona { get; set; }
        //public virtual Persona Persona { get; set; }
    }
}
