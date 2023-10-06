using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Authentication.API.DTOs
{
    public class RegisterModel
    {

        [Required(ErrorMessage = "Firstname is required")]
        [Display(Name = "Firstname")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lastname is required")]
        [Display(Name = "Lastname")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
