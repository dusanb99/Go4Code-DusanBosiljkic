using ProjektniZadatak.Controllers.Model;
using ProjektniZadatak.Models;
using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Services
{
    public interface IKorisnikService
    {
        public  Task<KorisniciGetDetailsResponse> CreateAsync(KorisniciCreateRequest korisnik);
        public Task<IEnumerable<KorisniciGetDetailsResponse>> GetAsync();
        public Task<KorisniciGetDetailsResponse> GetDetailsAsync(int id);
        public Task<bool> DeleteAsync(int id);

        Task<Korisnik> UpdateAsync(int id, KorisniciCreateRequest updatedKorisnik);
    }
}
