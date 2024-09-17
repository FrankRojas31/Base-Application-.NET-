using Base.Domain.Entidades.Seguridad;
using Base.Domain.Entidades.Universidad;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Base.Infraestructura.Datos.ContextoBD
{
    public class DataBaseContext : IdentityDbContext<ApplicationUser>
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        public DbSet<Formulario> Formularios { get; set; }
    }
}
