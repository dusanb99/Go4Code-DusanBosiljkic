using ProjektniZadatak.Repository;
using AutoMapper;
using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Services
{
    public interface IKorisnikService
    {
        

        public class KorisnikService: IKorisnikService
        {
            private readonly IKorisnikRepository _korisnikRepository;

            private readonly IMapper _mapper;



            

            public KorisnikService(IKorisnikRepository korisnikRepository, IMapper mapper)
            {
                   _korisnikRepository = korisnikRepository;
                   _mapper = mapper;
            }

            public KorisnikDTO getKorisnikById(int korisnikId)
            {
                var korisnikEntity = _korisnikRepository.GetById(korisnikId);

                if (korisnikEntity == null)
                {
                    return null;
                }
                var korisnikDTO = _mapper.Map<KorisnikDTO>(korisnikEntity);
                return korisnikDTO;
            }

            
        }
    }
}
