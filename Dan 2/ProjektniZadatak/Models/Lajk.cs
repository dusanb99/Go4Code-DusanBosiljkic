namespace ProjektniZadatak.Models
{
    public class Lajk
    {
        public int Id { get; set; }

        public int ObjavaId { get; set; }

        public int ? KomentarId { get; set; } // ID komentara koji je lajkovan

        public Objava PovezanaObjava { get; set; }

        public Komentar Komentar { get; set; }  // Komentar koji je lajkovan
    }
}
