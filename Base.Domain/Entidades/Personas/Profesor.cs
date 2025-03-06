using Base.Domain.Entidades.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Domain.Entidades.Personas
{
    [Table("Tbl_Profesor")]
    public class Profesor : BaseEntity
    {
        public string Cedula { get; set; }
        public string Especialidad { get; set; }
        public string Grado { get; set; }
        public int NoEmpleado { get; set; }

        [ForeignKey(nameof(Persona))]
        public int IdPersona { get; set; }
        public virtual Persona Persona { get; set; }
    }
}
