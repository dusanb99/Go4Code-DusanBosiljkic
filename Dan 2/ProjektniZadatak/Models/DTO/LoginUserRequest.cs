using System.ComponentModel.DataAnnotations;
namespace ProjektniZadatak.Models.DTO
{
    public class LoginUserRequest
    {

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
