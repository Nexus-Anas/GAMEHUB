using System.ComponentModel.DataAnnotations;

namespace GAMEHUB.WEB.BO.ViewModels;

public class LoginVM
{
    public string UserKey { get; set; }
    public string Name { get; set; }

    [Required(ErrorMessage = "Email is required")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }
}