using ProjektniZadatak.Models.DTO;
using ProjektniZadatak.Repository;
using AutoMapper;
using ProjektniZadatak.Models;

namespace ProjektniZadatak.Services
{


    public class KomentarService : IKomentarService
        {
            private readonly IKomentarRepository _komentarRepository;
            private readonly IMapper _mapper;

            public KomentarService (IKomentarRepository repository, IMapper mapper)
            {
                _komentarRepository = repository;
                _mapper = mapper;
            }

        

        public async Task<KomentarGetDetailsResponse> CreateAsync(KomentarCreateRequest komentar)
        {
            var komentarEntity = _mapper.Map<Komentar>(komentar);
            var result = await _komentarRepository.Create(komentarEntity);

            return _mapper.Map<KomentarGetDetailsResponse>(result);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var exists = await _komentarRepository.Get(id);

            if (exists == null)
            {
                return false;
            }

            await _komentarRepository.Delete(exists);

            return true;
        }

        public async Task<IEnumerable<KomentarGetDetailsResponse>> GetAsync()
        {
            var komentar = await _komentarRepository.GetAll();

            return _mapper.Map<IEnumerable<KomentarGetDetailsResponse>>(komentar);
        }

        public async Task<KomentarGetDetailsResponse> GetDetailsAsync(int id)
        {
            var komentar = await _komentarRepository.Get(id);

            if (komentar == null)
            {
                return null;
            }
            return _mapper.Map<KomentarGetDetailsResponse>(komentar);
        }



    }
        }
    

