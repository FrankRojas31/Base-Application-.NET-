
namespace Base.Domain.ViewModels.Seguridad
{
    public class ChangePasswordViewModel
    {
        public string Id { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
        
    }
}
