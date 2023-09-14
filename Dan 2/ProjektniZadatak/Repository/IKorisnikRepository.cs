using ProjektniZadatak.Controllers.Model;
using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Repository
{
    public interface IKorisnikRepository
    {
        public Task<Korisnik> GetById(int id);            
        void Update(KorisnikDTO user);    
        public Task<Korisnik> Create(Korisnik korisnik);
        public Task<IEnumerable<Korisnik>> GetAll();
        public Task Delete(Korisnik book);
    }
}
