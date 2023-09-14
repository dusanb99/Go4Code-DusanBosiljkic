using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjektniZadatak.Controllers.Model;
using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Repository
{
    

    public class KorisnikRepository : IKorisnikRepository
    {
        private readonly DrustvenaMrezaDbContext _context;
        public readonly DbSet<Korisnik> _collection;

        public KorisnikRepository(DrustvenaMrezaDbContext context)
        {
            _context = context;
        }

        public async Task<Korisnik> GetById(int id)
        {
            return await _collection.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Korisnik>> GetAll()
        {
            return await _collection.AsNoTracking().ToListAsync();
        }

        public async Task<Korisnik> Create(Korisnik korisnik)
        {
            await _collection.AddAsync(korisnik);
            await _context.SaveChangesAsync();

            return korisnik;
        }

        public void Update(Korisnik user)
        {
            _context.Korisnici.Entry(user).State = EntityState.Modified;
            //ovo gore je dosta cistije, update ako entitet ne postoji pokusa da ga unese..  _context.Korisnici.Update(user);
            _context.SaveChanges();
        }

        public async Task Delete (Korisnik korisnik)
        {
            _collection.Remove(korisnik);
            await _context.SaveChangesAsync();
        }

        public void Update(KorisnikDTO user)
        {
            throw new NotImplementedException();
        }
    }

}
