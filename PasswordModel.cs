using System.ComponentModel.DataAnnotations;
namespace WebApplication30.Models
{
    public class PasswordModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is Required.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirmation Password is Required")]
        [Compare("Password", ErrorMessage = "Password Must Match")]
        public string ConfirmPassword { get; set; }


    }


}
