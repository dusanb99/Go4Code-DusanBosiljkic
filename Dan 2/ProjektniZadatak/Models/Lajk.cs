namespace ProjektniZadatak.Models
{
    public class Lajk
    {
        public int Id { get; set; }

        public int ObjavaId { get; set; }

        public Objava PovezanaObjava { get; set; }
    }
}
