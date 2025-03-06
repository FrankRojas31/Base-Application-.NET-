using Base.Domain.DTO.Core;
using Base.Domain.Entidades.Core;
using Base.Domain.Entidades.Periodos;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.Domain.Entidades.Grupos
{
    public class GruposPeriodosDTO : BaseDTO
    {
        public int IdGrupo { get; set; }
        public int IdPeriodo { get; set; }
    }
}
