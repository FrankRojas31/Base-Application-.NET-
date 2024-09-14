using Base.Domain.Entidades.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.Domain.Entidades.Universidad
{
    [Table("Tbl_Formulario")]
    public class Formulario : BaseEntity
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool EsEstudiante { get; set; }
        public string Direccion { get; set; }
        public string Hobbie { get; set; }
    }
}
