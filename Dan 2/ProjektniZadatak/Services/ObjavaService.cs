using AutoMapper;
using ProjektniZadatak.Models;
using ProjektniZadatak.Models.DTO;
using ProjektniZadatak.Repository;

namespace ProjektniZadatak.Services
{
    public class ObjavaService : IObjavaService
    {
        private readonly IObjavaRepository _objavaRepository;

        private readonly IMapper _mapper;

        public ObjavaService(IObjavaRepository objavaRepository, IMapper mapper)
        {
            _objavaRepository = objavaRepository;

            _mapper = mapper;
        }

        public async Task<ObjaveGetDetailsResponse> CreateAsync(ObjaveCreateRequest objava) 
        {
            var objavaEntity = _mapper.Map<Objava>(objava);
            var result = await _objavaRepository.Create(objavaEntity);

            return _mapper.Map<ObjaveGetDetailsResponse>(result);

        }

        public async Task<bool> DeleteAsync (int id)
        {
            var exists = await _objavaRepository.Get(id);

            if (exists == null)
            {
                return false;
            }
            await _objavaRepository.Delete(exists);
            return true;
        }

        public async Task<IEnumerable<ObjaveGetDetailsResponse>> GetAsync ()
        {
          var objave =  await _objavaRepository.GetAll();

            return _mapper.Map<IEnumerable<ObjaveGetDetailsResponse>>(objave);
        }

        public async Task<ObjaveGetDetailsResponse> GetDetailsAsync (int id)
        {
            var objava = await _objavaRepository.Get(id);
            if (objava == null)
            {
                return null;
            }
            return _mapper.Map<ObjaveGetDetailsResponse>(objava);
        }
    }
}
