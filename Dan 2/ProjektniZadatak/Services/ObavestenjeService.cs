using AutoMapper;
using ProjektniZadatak.Models.DTO;
using ProjektniZadatak.Repository;

namespace ProjektniZadatak.Services
{
    public class ObavestenjeService : IObavestenjeService
    {
        private readonly IObavestenjeRepository _obavestenjeRepository;

        private readonly IMapper _mapper;

        public ObavestenjeService(IObavestenjeRepository repository, IMapper mapper)
        {
            _obavestenjeRepository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ObavestenjeGetDetailsResponse>> GetAsync()
        {
            var obavestenje = await _obavestenjeRepository.GetAll();

            return _mapper.Map<IEnumerable<ObavestenjeGetDetailsResponse>>(obavestenje);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var exists = await _obavestenjeRepository.Get(id);

            if (exists == null)
            {
                return false;
            }

            await _obavestenjeRepository.Delete(exists);

            return true;
        }
    }
}
