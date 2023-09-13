namespace ProjektniZadatak.Models.DTO
{
    public class KomentarDTO
    {

        public int Id { get; set; }

        public string Tekst { get; set; }

        public int objavaId { get; set; }

        public Objava PovezanaObjava { get; set; }


    }
}
