namespace ProjektniZadatak.Models.DTO
{
    public class ObavestenjeGetDetailsResponse
    {

        public int Id { get; set; }

        public int KorisnikId { get; set; }

        public string Tekst { get; set; }

        public bool Procitano { get; set; }
    }
}
