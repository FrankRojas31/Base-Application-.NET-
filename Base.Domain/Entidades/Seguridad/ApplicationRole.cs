using Microsoft.AspNetCore.Identity;

namespace Base.Domain.Entidades.Seguridad
{
    public class ApplicationRole : IdentityRole
    {
        public DateTime RowVersion { get; set; }
        public string AppUser { get; set; }
        public bool IsDeleted { get; set; }
    }

}
