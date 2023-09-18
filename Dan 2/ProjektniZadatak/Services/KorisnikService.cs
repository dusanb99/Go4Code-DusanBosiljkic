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

        public async Task<Korisnik> UpdateAsync(int id, KorisniciCreateRequest updatedKorisnik)
        {
            // Prvo proverite da li korisnik sa datim ID-om postoji
            var existingKorisnik = await _korisnikRepository.Get(id);

            if (existingKorisnik == null)
            {
                return null; // Korisnik sa datim ID-om nije pronađen
            }

            // Ažurirajte postojećeg korisnika sa podacima iz updatedKorisnik
            existingKorisnik.Ime = updatedKorisnik.Ime;
            existingKorisnik.Prezime = updatedKorisnik.Prezime;
            // Dodajte ostala polja korisnika koja želite ažurirati

            // Pozovite metodu za ažuriranje u repozitorijumu za korisnike da sačuvate promene u skladištu podataka
            var updatedKorisnikInRepo = await _korisnikRepository.UpdateAsync(id, existingKorisnik);

            if (updatedKorisnikInRepo == null)
            {
                // Repozitorijum za korisnike nije uspeo ažurirati korisnika
                // Možete ovde obraditi ovu situaciju po potrebi
                return null;
            }

            return updatedKorisnikInRepo; // Vratite ažuriranog korisnika
        }








    }
    }

