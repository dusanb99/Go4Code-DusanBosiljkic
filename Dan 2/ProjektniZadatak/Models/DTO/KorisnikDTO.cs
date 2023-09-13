using ProjektniZadatak.Controllers.Model;

namespace ProjektniZadatak.Models.DTO
{
    public class KorisnikDTO
    {
        public int id { get; set; }

        public string ime { get; set; }

        public List<Models.Objava> Objave {  get; set; }

        public List<Controllers.Model.Korisnik> praceniKorisnici {  get; set; }
    }
}
