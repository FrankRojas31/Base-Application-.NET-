using Base.Domain.DTO.Core;

namespace Base.Domain.DTOs
{
    public class FormularioDTO : BaseDTO
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool EsEstudiante { get; set; }
        public string Direccion { get; set; }
        public string Hobbie { get; set; }
    }
}
