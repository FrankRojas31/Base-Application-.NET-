using Base.Domain.Entidades.Seguridad;
using Base.Infraestructura.Data.Repositorios.Contrato.Seguridad;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Security.Cryptography;
using Base.Infraestructura.Data.Repositories.Implementation;
using Base.Infraestructura.Datos.ContextoBD;

namespace Base.Infraestructura.Data.Repositorios.Implementacion.Seguridad
{
    public class ApplicationUserRepository : BaseRepository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly DataBaseContext _context;

        public ApplicationUserRepository(DataBaseContext context, ClaimsPrincipal user) : base(context, user)
        {
            _context = context;
        }

        public async Task<string> GenerateRefreshToken()
        {
            var token = "";
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                token = Convert.ToBase64String(randomNumber);

                //var esUnico = await _genericRepositoryApplicationUser.ExisteElemento(x => x.RefreshToken == token);
                string query = @"SELECT * FROM [AspNetUsers] as p WHERE RefreshToken = @token";
                var tokenUser = await _context.Database.GetDbConnection().QueryFirstOrDefaultAsync<ApplicationUser>(query, new { token });
                if (tokenUser != null)
                {
                    return await GenerateRefreshToken();
                }
            }
            return token;
        }

    }

}
