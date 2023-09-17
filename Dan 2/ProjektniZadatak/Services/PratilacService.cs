using AutoMapper;
using ProjektniZadatak.Controllers.Model;
using ProjektniZadatak.Models;
using ProjektniZadatak.Models.DTO;
using ProjektniZadatak.Repository;

namespace ProjektniZadatak.Services
{
    public class PratilacService : IPratilacService
    {
        private readonly IPratilacRepository _pratilacRepository;

        private readonly IMapper _mapper;

        public PratilacService (IPratilacRepository pratilacRepository, IMapper mapper)
        {
            _pratilacRepository = pratilacRepository;
            _mapper = mapper;
        }

        public async Task<PratilacGetDetailsResponse> CreateAsync (PratilacCreateRequest pratilac)
        {
            var pratilacEntity = _mapper.Map<Pratilac>(pratilac);
            var result = await _pratilacRepository.Add(pratilacEntity);

            return _mapper.Map<PratilacGetDetailsResponse>(result);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var exists = await _pratilacRepository.Get(id);

            if (exists == null)
            {
                return false;
            }

            await _pratilacRepository.Delete(exists);

            return true;
        }

        public async Task<IEnumerable<PratilacGetDetailsResponse>> GetAsync()
        {
            var pratioci = await _pratilacRepository.GetAll();

            return _mapper.Map<IEnumerable<PratilacGetDetailsResponse>>(pratioci);
        }

        public async Task<PratilacGetDetailsResponse> GetDetailsAsync(int id)
        {
            var pratilac = await _pratilacRepository.Get(id);

            if (pratilac == null)
            {
                return null;
            }
            return _mapper.Map<PratilacGetDetailsResponse>(pratilac);
        }
    }
}
