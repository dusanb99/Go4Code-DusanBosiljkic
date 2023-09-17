using ProjektniZadatak.Controllers.Model;
using ProjektniZadatak.Models;

namespace ProjektniZadatak.Repository
{
    public interface IPratilacRepository
    {

        public Task<Pratilac> Get(int id);
        public Task<Pratilac> Add(Pratilac pratilac);
        public Task<IEnumerable<Pratilac>> GetAll();
        public Task Delete(Pratilac pratilac);
    }
}
