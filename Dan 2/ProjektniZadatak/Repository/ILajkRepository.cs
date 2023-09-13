using ProjektniZadatak.Models;

namespace ProjektniZadatak.Repository
{
    public interface ILajkRepository
    {
        

        IEnumerable<Lajk> getAll();

        void Create(Lajk lajk);

        void Update(Lajk lajk);

        void Delete(Lajk lajk);

    }
}
