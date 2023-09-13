using ProjektniZadatak.Models.DTO;
using ProjektniZadatak.Repository;
using AutoMapper;

namespace ProjektniZadatak.Services
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

        public List<KomentarDTO> getAll()
        {
            return _repository.getAll();
        }

            }
        }
    

