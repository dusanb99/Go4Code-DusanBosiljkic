using ProjektniZadatak.Models;
using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Repository
{
    public interface IKomentarRepository
    {
       

        List<KomentarDTO> getAll();

        void Create(Komentar komentar);

        void Update(Komentar komentar);

        void Delete(Komentar komentar);


    }
}
