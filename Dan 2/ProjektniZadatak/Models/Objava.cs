using ProjektniZadatak.Controllers.Model;
using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Models
{
    public class Objava
    {
        public int Id { get; set; }
        
        public string Naslov { get; set; }

        public string Tekst { get; set; }
        
        public List<Komentar> Komentari { get; set; }

        public List<Lajk> Lajkovi { get; set; }

        
    }
}
