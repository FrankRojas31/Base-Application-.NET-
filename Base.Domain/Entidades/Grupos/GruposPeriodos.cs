using Base.Domain.Entidades.Core;
using Base.Domain.Entidades.Periodos;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.Domain.Entidades.Grupos
{
    [Table("Tbl_GruposPeriodos")]
    public class GruposPeriodos : BaseEntity
    {
        [ForeignKey(nameof(Grupos))]
        public int IdGrupo { get; set; }
        public virtual Grupo Grupos { get; set; }

        [ForeignKey(nameof(Periodos))]
        public int IdPeriodo { get; set; }
        public virtual Periodo Periodos { get; set; }

    }
}
