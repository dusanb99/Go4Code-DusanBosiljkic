using ProjektniZadatak.Repository;
using AutoMapper;
using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Services
{
    public interface IObjavaService
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

           public ObjavaDTO getObjavaById (int id)
            {
                var objavaEntity = _objavaRepository.getById(id);

                if (objavaEntity == null)
                {
                    return null;
                }

                var objavaDTO = _mapper.Map<ObjavaDTO>(objavaEntity);
                return objavaDTO; 
            }
        }
    }
}
