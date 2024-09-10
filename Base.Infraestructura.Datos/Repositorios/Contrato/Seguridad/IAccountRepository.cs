using Base.Domain.DTO.Security;
using Base.Domain.Entidades.Seguridad;
using Base.Domain.ViewModels;
using Base.Domain.ViewModels.Seguridad;
using Microsoft.AspNetCore.Identity;

namespace Base.Infraestructura.Data.Repositorios.Contrato.Seguridad
{
    public interface IAccountRepository
    {

        Task<bool> CheckPasswordAsync(ApplicationUser user, LoginDTO loginDTO);
        string GenerateAccessToken(UserSession user);

        Task<bool> CreateAccount(UserDTO userDTO);
        Task<bool> UpdateAccount(UserDTO userDTO);
        Task<bool> UpdateUserData(UserDTO userDTO);
        Task<bool> ChangePassword(ChangePasswordViewModel vm);
        Task<List<ApplicationUser>> GetAllUsersAsync();
        Task<ApplicationUser> FindByEmailAsync(string email);
        Task<ApplicationUser> FindByIdAsync(string id);
        Task<UserDTO> GetDTOByEmailAsync(string email);
        Task<UserDTO> GetDTOByIdAsync(string id);

        Task<bool> CreateRol(string rol);
        Task<bool> UpdateRol(IdentityRole rol);
        Task<bool> DeleteRol(IdentityRole rol);
        Task<IList<string>> GetRolesAsync(ApplicationUser user);
        Task<List<IdentityRole>> GetAllRolesAsync();
        Task<IdentityRole> GetRolByNameAsync(string name);
        Task<IdentityRole> GetRolByIdAsync(string id);
        bool AnyRoles();
        bool AnyUsers();
        Task<bool> DeleteUser(ApplicationUser user);
    }
}
