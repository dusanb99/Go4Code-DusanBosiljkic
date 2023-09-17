using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjektniZadatak.Controllers.Model;
using ProjektniZadatak.Models;

namespace ProjektniZadatak.Repository
{
    

    public class LajkRepository : ILajkRepository
    {
        public readonly DrustvenaMrezaDbContext _context;

        public readonly DbSet<Lajk> _collection;

        
        
        public LajkRepository(DrustvenaMrezaDbContext context)
        {
            _context = context;
            _collection = _context.Lajkovi;
        }

        

        public async Task <Lajk> Get (int id)
        {
            return await _collection.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Lajk>> GetAll()
        {
            return await _collection.AsNoTracking().ToListAsync();
        }

        public async Task<Lajk> Add(Lajk lajk)
        {
            await _collection.AddAsync(lajk);
            await _context.SaveChangesAsync();

            return lajk;
        }

        public void Update(Lajk lajk)
        {
            _context.Lajkovi.Entry(lajk).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public async Task Delete(Lajk lajk)
        {
            _collection.Remove(lajk);
            await _context.SaveChangesAsync();
        }
    }
}
