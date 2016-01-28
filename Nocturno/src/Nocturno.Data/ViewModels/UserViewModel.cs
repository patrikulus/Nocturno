using System.ComponentModel.DataAnnotations;

namespace Nocturno.Data.ViewModels
{
    public class UserViewModel
    {
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        [Required]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-Z0-9]+[a-zA-Z0-9]*", ErrorMessage = "Username is not valid")]
        [Display(Name = "Username")]
        [Required]
        public string UserName { get; set; }

        public string Role { get; set; }
        public string UserId { get; set; }

        // TODO Use it to display roles in Index view
        // public IDictionary<ApplicationUser, string> UsersWithRoles { get; set; }
    }
}