using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Services
{
    public interface ILajkService
    {
        public Task<LajkGetDetailsResponse> CreateAsync(LajkCreateRequest lajk);
        public Task<IEnumerable<LajkGetDetailsResponse>> GetAsync();
        public Task<LajkGetDetailsResponse> GetDetailsAsync(int id);
        public Task<bool> DeleteAsync(int id);
    }
}
