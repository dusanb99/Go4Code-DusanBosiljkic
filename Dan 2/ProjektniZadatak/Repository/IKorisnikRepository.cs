using ProjektniZadatak.Controllers.Model;
using ProjektniZadatak.Models;
using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Repository
{
    public interface IKorisnikRepository
    {
        public Task<Korisnik> Get(int id);               
        public Task<Korisnik> Add(Korisnik korisnik);
        public Task<IEnumerable<Korisnik>> GetAll();
        public Task Delete(Korisnik korisnik);

        public Task<Korisnik> UpdateAsync(int id, Korisnik updatedKorisnik);
    }
}
