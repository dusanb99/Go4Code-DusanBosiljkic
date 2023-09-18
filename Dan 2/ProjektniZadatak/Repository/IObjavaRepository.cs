using ProjektniZadatak.Controllers.Model;
using ProjektniZadatak.Models;
using ProjektniZadatak.Models.DTO;
using System.Threading.Tasks;

namespace ProjektniZadatak.Repository
{
    public interface IObjavaRepository
    {
        public Task<Objava> Get(int id);
        public Task<Objava> Create(Objava objava);
        public Task<IEnumerable<Objava>> GetAll();
        public Task Delete(Objava objava);

        public Task<Objava> UpdateAsync(int id, Objava updatedObjava);


    }
}
