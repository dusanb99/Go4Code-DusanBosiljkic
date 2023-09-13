using ProjektniZadatak.Models;
using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Repository
{
    public interface IObjavaRepository
    {
        Objava getById(int id);

        List<ObjavaDTO> GetAll();

        void Create(Objava objava);

        void Update(Objava objava);

        void Delete(Objava objava);


    }
}
