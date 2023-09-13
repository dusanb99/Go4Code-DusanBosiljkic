using AutoMapper;
using ProjektniZadatak.Models.DTO;
using ProjektniZadatak.Repository;

namespace ProjektniZadatak.Services
{
    public class ObjavaService
    {
        private readonly IObjavaRepository _objavaRepository;

        private readonly IMapper _mapper;

        public ObjavaService(IObjavaRepository objavaRepository, IMapper mapper)
        {
            _objavaRepository = objavaRepository;

            _mapper = mapper;
        }

        public ObjavaDTO getById(int id)
        {
            var objavaEntity = _objavaRepository.getById(id);

            if (objavaEntity == null)
            {
                return null;
            }

            var objavaDTO = _mapper.Map<ObjavaDTO>(objavaEntity);
            return objavaDTO;
        }

        public List<ObjavaDTO> getAll()
        {
            return _objavaRepository.GetAll();
        }
    }
}
