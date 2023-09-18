using ProjektniZadatak.Models;
using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Services
{
    public interface IObjavaService
    {

        public Task<ObjaveGetDetailsResponse> CreateAsync(ObjaveCreateRequest objava);
        public Task<IEnumerable<ObjaveGetDetailsResponse>> GetAsync();
        public Task<ObjaveGetDetailsResponse> GetDetailsAsync(int id);
        public Task<bool> DeleteAsync(int id);

        Task<Objava> UpdateAsync(int id, ObjaveCreateRequest updatedObjava);
    }
}
