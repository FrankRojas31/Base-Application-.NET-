using Base.Domain.Entidades.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.Domain.Entidades.Personas
{
    [Table("Tbl_Persona")]
    public class Persona : BaseEntity
    {
        public string Nombres { get; set; }
        public string Apellido_Materno { get; set; }
        public string Apellido_Paterno { get; set; }
    }
}
