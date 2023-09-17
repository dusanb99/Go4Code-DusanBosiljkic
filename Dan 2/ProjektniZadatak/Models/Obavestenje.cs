namespace ProjektniZadatak.Models
{
    public class Obavestenje
    {
        public int Id { get; set; }

        public int KorisnikId { get; set; }

        public string Tekst {  get; set; }

        public bool Procitano { get; set; }

        public DateTime DatumSlanja { get; set; }
    }
}
