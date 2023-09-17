using ProjektniZadatak.Controllers.Model;
using ProjektniZadatak.Models;
using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Repository
{
    public interface IKomentarRepository
    {

        public Task<Komentar> Get(int id);
        public Task<Komentar> Create(Komentar komentar);
        public Task<IEnumerable<Komentar>> GetAll();
        public Task Delete(Komentar komentar);


    }
}
