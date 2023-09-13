using System.ComponentModel.DataAnnotations;

namespace ProjektniZadatak.Models
{
    public class Komentar
    {
        public int Id { get; set; }


        [MaxLength(200)]
        public string Tekst { get; set; }

        public int objavaId { get; set; }

        public Objava PovezanaObjava { get; set; }
    }
}
