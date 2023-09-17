using Microsoft.EntityFrameworkCore;
using ProjektniZadatak.Models;

namespace ProjektniZadatak.Repository
{
    public class ObavestenjeRepository : IObavestenjeRepository
    {

        private readonly DrustvenaMrezaDbContext _context;

        public readonly DbSet<Obavestenje> _collection;


        public ObavestenjeRepository(DrustvenaMrezaDbContext context)
        {
            _context = context;

            _collection = _context.Obavestenja;
        }

        public async Task<IEnumerable<Obavestenje>> GetAll()
        {
            return await _collection.AsNoTracking().ToListAsync();
        }

        public async Task<Obavestenje> Get(int id)
        {
            return await _collection.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Add(Obavestenje obavestenje)
        {
            await _collection.AddAsync(obavestenje);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Obavestenje obavestenje)
        {
            _collection.Remove(obavestenje);
            await _context.SaveChangesAsync();
        }
    }
}
