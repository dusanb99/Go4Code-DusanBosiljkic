using AutoMapper;
using ProjektniZadatak.Models;
using ProjektniZadatak.Models.DTO;
using ProjektniZadatak.Repository;

namespace ProjektniZadatak.Services

{

        public class LajkService : ILajkService

        {
            private readonly ILajkRepository _lajkRepository;
            private readonly IMapper _mapper;

            public LajkService(ILajkRepository lajkRepository, IMapper mapper)
            {
                _lajkRepository = lajkRepository;
                _mapper = mapper;
            }

        public async Task<LajkGetDetailsResponse> CreateAsync(LajkCreateRequest lajk)
        {
            var lajkEntity = _mapper.Map<Lajk>(lajk);
            var result = await _lajkRepository.Add(lajkEntity);

            return _mapper.Map<LajkGetDetailsResponse>(result);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var exists = await _lajkRepository.Get(id);

            if (exists == null)
            {
                return false;
            }

            await _lajkRepository.Delete(exists);

            return true;
        }

        public async Task<IEnumerable<LajkGetDetailsResponse>> GetAsync()
        {
            var lajk = await _lajkRepository.GetAll();

            return _mapper.Map<IEnumerable<LajkGetDetailsResponse>>(lajk);
        }

        public async Task<LajkGetDetailsResponse> GetDetailsAsync(int id)
        {
            var lajk = await _lajkRepository.Get(id);

            if (lajk == null)
            {
                return null;
            }
            return _mapper.Map<LajkGetDetailsResponse>(lajk);
        }

    }
    }

