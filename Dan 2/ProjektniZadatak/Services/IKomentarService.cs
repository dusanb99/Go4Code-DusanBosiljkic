using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Services
{
    public interface IKomentarService
    {
        public Task<KomentarGetDetailsResponse> CreateAsync(KomentarCreateRequest komentar);
        public Task<IEnumerable<KomentarGetDetailsResponse>> GetAsync();
        public Task<KomentarGetDetailsResponse> GetDetailsAsync(int id);
        public Task<bool> DeleteAsync(int id);

    }
}
