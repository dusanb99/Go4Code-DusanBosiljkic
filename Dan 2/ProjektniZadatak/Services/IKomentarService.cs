using ProjektniZadatak.Models.DTO;
using ProjektniZadatak.Repository;
using AutoMapper;

namespace ProjektniZadatak.Services
{
    public interface IKomentarService
    {

        public class KomentarService : IKomentarService
        {
            private readonly IKomentarRepository _repository;
            private readonly IMapper _mapper;

            public KomentarService (IKomentarRepository repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public KomentarDTO getKomentarById(int komentarId)
            {
                var komentarEntity = _repository.getById(komentarId);

                if (komentarEntity == null)
                {
                    return null;
                }
                var komentarDTO = _mapper.Map<KomentarDTO>(komentarEntity);
                return komentarDTO;
            }
            

            }
        }
    }
}
