using ProjektniZadatak.Repository;
using AutoMapper;
using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Services
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

            public KorisnikDTO getById(int korisnikId)
            {
                KorisnikDTO korisnik = _korisnikRepository.GetById(korisnikId);

                if (korisnik == null)
                {
                    return null;
                }

                return korisnik;
                
            }

        public List<KorisnikDTO> getAll()
        {
            return _korisnikRepository.GetAll();
        }

        public void update(KorisnikDTO korisnik)
        {
            var postojeciKorisnik = _korisnikRepository.GetById(korisnik.id);

            if (postojeciKorisnik == null)
            {
                return;
            }

            postojeciKorisnik.ime = korisnik.ime;

            _korisnikRepository.Update(postojeciKorisnik);
            

        }




    }
    }

