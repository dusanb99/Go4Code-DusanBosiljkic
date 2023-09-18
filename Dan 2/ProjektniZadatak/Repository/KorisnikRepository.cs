using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjektniZadatak.Controllers.Model;
using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Repository
{
    

    public class KorisnikRepository : IKorisnikRepository
    {
        public readonly DrustvenaMrezaDbContext _context;
        public readonly DbSet<Korisnik> _collection;

        public KorisnikRepository(DrustvenaMrezaDbContext context)
        {
            _context = context;
            _collection = _context.Korisnici;
        }

        public async Task<Korisnik> Get(int id)
        {
            return await _collection.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Korisnik>> GetAll()
        {
            return await _collection.AsNoTracking().ToListAsync();
        }

        public async Task<Korisnik> Add(Korisnik korisnik)
        {
            await _collection.AddAsync(korisnik);
            await _context.SaveChangesAsync();

            return korisnik;
        }

        public async Task<Korisnik> UpdateAsync(int id, Korisnik updatedKorisnik)
        {
            var existingKorisnik = await _context.Korisnici.FindAsync(id);

            if (existingKorisnik == null)
            {
                return null; // Korisnik sa datim ID-om nije pronađen
            }

            // Ažurirajte polja korisnika prema updatedKorisnik
            existingKorisnik.Ime = updatedKorisnik.Ime;
            existingKorisnik.Prezime = updatedKorisnik.Prezime;
            // Dodajte ostala polja koja želite ažurirati

            // Sačuvajte promene u bazi podataka
            await _context.SaveChangesAsync();

            return existingKorisnik; // Vratite ažuriranog korisnika
        }

        public async Task Delete (Korisnik korisnik)
        {
            _collection.Remove(korisnik);
            await _context.SaveChangesAsync();
        }

        
    }

}
