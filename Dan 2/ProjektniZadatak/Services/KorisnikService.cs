using ProjektniZadatak.Repository;
using AutoMapper;
using ProjektniZadatak.Models.DTO;
using ProjektniZadatak.Controllers.Model;

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


        public async Task<KorisniciGetDetailsResponse> CreateAsync(KorisniciCreateRequest korisnik)
        {
            var korisnikEntity = _mapper.Map<Korisnik>(korisnik);
            var result = await _korisnikRepository.Create(korisnikEntity);

            return _mapper.Map<KorisniciGetDetailsResponse>(result);
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

        public void Update(KorisnikDTO dto)
        {
            throw new NotImplementedException();
        }
    }
    }

