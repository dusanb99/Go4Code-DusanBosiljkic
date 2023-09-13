using ProjektniZadatak.Controllers.Model;
using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Repository
{
    public interface IKorisnikRepository
    {
        KorisnikDTO GetById(int id);
        List<KorisnikDTO> GetAll();
        void Create(Korisnik user);
        void Update(KorisnikDTO user);
        void Delete(Korisnik user);
    }
}
