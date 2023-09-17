namespace ProjektniZadatak.Models.DTO
{
    public class KorisniciCreateRequest
    {

        public string Ime { get; set; }

        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

    }
}
