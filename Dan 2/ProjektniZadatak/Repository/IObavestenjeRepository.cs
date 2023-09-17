using ProjektniZadatak.Controllers.Model;
using ProjektniZadatak.Models;

namespace ProjektniZadatak.Repository
{
    public interface IObavestenjeRepository
    {

        public Task<Obavestenje> Get(int id);
        public Task Add(Obavestenje obavestenje);
        public Task<IEnumerable<Obavestenje>> GetAll();

        public Task Delete(Obavestenje obavestenje);

    }
}
