using ProjektniZadatak.Controllers.Model;
using ProjektniZadatak.Models;
using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Repository
{
    public interface IObjavaRepository
    {
        public Task<Objava> Get(int id);
        public Task<Objava> Create(Objava objava);
        public Task<IEnumerable<Objava>> GetAll();
        public Task Delete(Objava objava);


    }
}
