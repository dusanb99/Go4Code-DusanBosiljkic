using Microsoft.EntityFrameworkCore;
using ProjektniZadatak.Models;

namespace ProjektniZadatak.Repository
{
    public class PratilacRepository : IPratilacRepository
    {

        public readonly DrustvenaMrezaDbContext _context;
        public readonly DbSet<Pratilac> _collection;

        public PratilacRepository(DrustvenaMrezaDbContext context)
        {
            _context = context;
            _collection = _context.Pratioci;
        }

        public async Task<IEnumerable<Pratilac>> GetAll()
        {
            return await _collection.AsNoTracking().ToListAsync();
        }

        public async Task<Pratilac> Get(int id)
        {
            return await _collection.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Pratilac> Add(Pratilac pratilac)
        {
            await _collection.AddAsync(pratilac);
            await _context.SaveChangesAsync();

            return pratilac;

        }

        public async Task Update(Pratilac pratilac)
        {
            _context.Entry(pratilac).State = EntityState.Modified;
        }

        public async Task Delete (Pratilac pratilac)
        {
            _collection.Remove(pratilac);
          await _context.SaveChangesAsync();
        }
       

        
    }
}
