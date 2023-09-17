namespace ProjektniZadatak.Models.DTO
{
    public class LajkCreateRequest
    {
        public int ObjavaId { get; set; } // ID objave koja se lajkuje
        public int? KomentarId { get; set; } // ID komentara koji se lajkuje (opciono)
        //public int KorisnikId { get; set; } // ID korisnika koji daje lajk
    }
}
