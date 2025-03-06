using Base.Domain.DTO.Core;
using Base.Domain.Entidades.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.Domain.Entidades.Personas
{
    public class PersonaDTO : BaseDTO
    {
        public string Nombres { get; set; }
        public string Apellido_Materno { get; set; }
        public string Apellido_Paterno { get; set; }
    }
}
