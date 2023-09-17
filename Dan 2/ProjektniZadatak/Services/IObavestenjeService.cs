using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Services
{
    public interface IObavestenjeService
    {
        public Task<IEnumerable<ObavestenjeGetDetailsResponse>> GetAsync();

        public Task<bool> DeleteAsync(int id);
    }
}
