using System.ComponentModel.DataAnnotations;

namespace ProjektniZadatak.Models
{
    public class Komentar
    {
        public int Id { get; set; }

        public string Tekst { get; set; }

        public int ObjavaId { get; set; }

        public Objava Objava { get; set; }

        public List<Lajk> KomentarLajkovi { get; set; } // Lista lajkova povezanih sa ovim komentarom


    }
}
