using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Services
{
    public interface IKorisnikService
    {
        KorisnikDTO getById(int id);
        List<KorisnikDTO> getAll();

        void Update(KorisnikDTO dto);
    }
}
