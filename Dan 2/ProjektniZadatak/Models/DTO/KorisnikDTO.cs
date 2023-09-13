using ProjektniZadatak.Controllers.Model;

namespace ProjektniZadatak.Models.DTO
{
    public class KorisnikDTO
    {
        public int id { get; set; }

        public string ime { get; set; }

        public List<Objava> Objave {  get; set; }

        public List<Korisnik> praceniKorisnici {  get; set; }
    }
}
