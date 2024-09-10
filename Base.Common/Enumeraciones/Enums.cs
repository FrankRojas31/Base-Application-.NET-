using System.ComponentModel.DataAnnotations;

namespace Base.Common.Enumeraciones
{
    public class Enums
    {
        public enum EstatusUsuario
        {
            [Display(Name = "Activo")] ACTIVO, INACTIVO
        }
    }
}
