using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Services
{
    public interface IObjavaService
    {

        ObjavaDTO getById(int id);

        List<ObjavaDTO> getAll();
    }
}
