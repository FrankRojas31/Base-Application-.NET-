using Base.Domain.Entidades.Seguridad;

namespace Base.Infraestructura.Data.Repositorios.Contrato.Seguridad
{
    public interface IApplicationUserRepository : IBaseRepository<ApplicationUser>
    {
        Task<string> GenerateRefreshToken();
    }
}
