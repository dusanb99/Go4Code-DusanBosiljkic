using ProjektniZadatak.Controllers.Model;

namespace ProjektniZadatak.Models
{
    public class Pratilac
    {

        public int Id { get; set; }

        public int PratilacId { get; set; } // ID korisnika koji prati drugog korisnika

        public int PraceniKorisnikId { get; set; } // ID korisnika koji se prati

        public Korisnik PratilacKorisnika{  get; set; } // Korisnik koji prati

        public Korisnik PraceniKorisnik { get; set; }  // Korisnik koji se prati




    }
}
