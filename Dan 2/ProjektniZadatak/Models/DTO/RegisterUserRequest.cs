using System.ComponentModel.DataAnnotations;

namespace ProjektniZadatak.Models.DTO
{
    public class RegisterUserRequest
    {

        [Required]

        public string Username { get; set; }


        [EmailAddress]
           [Required]
        public string Email { get; set; }


        [Required]
        public string Password { get; set; }
    }
}
