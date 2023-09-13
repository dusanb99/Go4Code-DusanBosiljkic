namespace ProjektniZadatak.Models.DTO
{
    public class LajkDTO
    {

        public int id { get; set; }

        public int ObjavaId { get; set; }

        public Models.Objava povezanaObjava { get; set; }


    }
}
