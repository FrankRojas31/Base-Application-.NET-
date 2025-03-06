using Base.Domain.Entidades.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Domain.Entidades.Grupos.Clases
{
    [Table("Tbl_UnidadesMaterias")]
    public class UnidadesMaterias : BaseEntity
    {
        [ForeignKey(nameof(Unidad))]
        public int IdUnidad { get; set; }
        public virtual Unidades Unidad { get; set; }

        [ForeignKey(nameof(Materia))]
        public int IdMateria { get; set; }
        public virtual Materias Materia { get; set; }
    }
}
