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
            var result = await _korisnikRepository.Add(korisnikEntity);

            return _mapper.Map<KorisniciGetDetailsResponse>(result);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var exists = await _korisnikRepository.Get(id);

            if (exists == null)
            {
                return false;
            }

            await _korisnikRepository.Delete(exists);

            return true;
        }

        public async Task<IEnumerable<KorisniciGetDetailsResponse>> GetAsync()
        {
            var korisnici = await _korisnikRepository.GetAll();

            return _mapper.Map<IEnumerable<KorisniciGetDetailsResponse>>(korisnici);
        }

        public async Task<KorisniciGetDetailsResponse> GetDetailsAsync(int id)
        {
            var korisnik = await _korisnikRepository.Get(id);

            if (korisnik == null)
            {
                return null;
            }
            return _mapper.Map<KorisniciGetDetailsResponse>(korisnik);
        }

        

        

        

        
    }
    }

