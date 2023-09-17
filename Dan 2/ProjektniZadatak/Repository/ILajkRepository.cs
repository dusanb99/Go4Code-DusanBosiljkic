using ProjektniZadatak.Models;
using System.Diagnostics.Contracts;

namespace ProjektniZadatak.Repository
{
    public interface ILajkRepository
    {


        public Task<Lajk> Get(int id);
        public Task<Lajk> Add(Lajk lajk);
        public Task<IEnumerable<Lajk>> GetAll();
        public Task Delete(Lajk lajk);


    }
}
