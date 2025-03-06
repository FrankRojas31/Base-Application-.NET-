using Base.Domain.Entidades.Grupos;
using Base.Domain.Entidades.Grupos.Clases;
using Base.Domain.Entidades.Periodos;
using Base.Domain.Entidades.Personas;
using Base.Domain.Entidades.Seguridad;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Base.Infraestructura.Datos.ContextoBD
{
    public class DataBaseContext : IdentityDbContext<ApplicationUser>
    {
        DbSet<Grupo> Grupos { get; set; }
        DbSet<GruposAlumnos> GruposAlumnos { get; set; }
        DbSet<GruposPeriodos> GruposPeriodos { get; set; }
        DbSet<Periodo> Periodo { get; set; }
        DbSet<Alumno> Alumnos { get; set; }
        DbSet<Profesor> Profesor { get; set; }
        DbSet<Materias> Materias { get; set; }
        DbSet<Unidades> Unidades { get; set; }
        DbSet<UnidadesMaterias> UnidadesMaterias { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
    }
}
