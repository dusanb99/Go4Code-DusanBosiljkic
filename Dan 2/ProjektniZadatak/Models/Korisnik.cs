using ProjektniZadatak.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjektniZadatak.Controllers.Model
{
    public class Korisnik
    {

        public int Id { get; set; }

        [MaxLength(32)]
        public string Ime { get; set; }

        public List<Objava> Objave { get; set; }

        public List<Korisnik> PraceniKorisnici { get; set; }

       
    }

    
}
