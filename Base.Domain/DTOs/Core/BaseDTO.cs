using System.ComponentModel.DataAnnotations;

namespace Base.Domain.DTO.Core
{
    public abstract class BaseDTO
    {
        public int? Id { get; set; }
        public bool? EsBorrado { get; set; }
    }
}
