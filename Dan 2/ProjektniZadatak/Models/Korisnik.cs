using ProjektniZadatak.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjektniZadatak.Controllers.Model
{
    public class Korisnik
    {

        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Ime { get; set; }

        public string Prezime {  get; set; }

        public List<Obavestenje> Obavestenja { get; set; }

        public List<Objava> Objave {  get; set; }

        public List<Pratilac> Pratioci {  get; set; }

        
       
    }

    
}
