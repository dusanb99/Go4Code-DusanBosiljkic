using AutoMapper;
using ProjektniZadatak.Models.DTO;
using ProjektniZadatak.Repository;

namespace ProjektniZadatak.Services
    
{
    public interface ILajkService
    {

    }

    public class LajkService : ILajkService 
    {
        private readonly ILajkRepository _lajkRepository;
        private readonly IMapper _mapper;

        public LajkService(ILajkRepository lajkRepository, IMapper mapper)
        {
            _lajkRepository = lajkRepository;
            _mapper = mapper;
        }

        public LajkDTO getLajkById(int id)
        {
            var lajkEntity = _lajkRepository.getById(id);

            if (lajkEntity == null)
            {
                return null;
            }

            var lajkDTO = _mapper.Map<LajkDTO>(lajkEntity);
            return lajkDTO;
        }
        
    }
}
