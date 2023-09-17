using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Services
{
    public interface IPratilacService 
    {
        public Task<PratilacGetDetailsResponse> CreateAsync(PratilacCreateRequest pratilac);
        public Task<IEnumerable<PratilacGetDetailsResponse>> GetAsync();
        public Task<PratilacGetDetailsResponse> GetDetailsAsync(int id);
        public Task<bool> DeleteAsync(int id);
    }
}
