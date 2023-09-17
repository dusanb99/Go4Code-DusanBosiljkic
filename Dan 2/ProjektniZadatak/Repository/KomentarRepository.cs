using Microsoft.EntityFrameworkCore;
using ProjektniZadatak.Controllers.Model;
using ProjektniZadatak.Models;
using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Repository
{
    

    public class KomentarRepository : IKomentarRepository
    {
        private readonly DrustvenaMrezaDbContext _context;

        public readonly DbSet<Komentar> _collection;

        public KomentarRepository(DrustvenaMrezaDbContext context, DbSet<Komentar> collection)
        {
            _context = context;
            _collection = collection;
        }



        public async Task<IEnumerable<Komentar>> GetAll()
        {
            return await _collection.AsNoTracking().ToListAsync();
        }

        public async Task<Komentar> Get(int id)
        {
            return await _collection.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Komentar> Create(Komentar komentar)
        {
            await _collection.AddAsync(komentar);
            await _context.SaveChangesAsync();

            return komentar;
        }

        public void Update(Komentar komentar)
        {
            _context.Komentari.Entry(komentar).State = EntityState.Modified;
            //ovo gore je dosta cistije, update ako entitet ne postoji pokusa da ga unese..  _context.Korisnici.Update(user);
            _context.SaveChanges();
        }


        public async Task Delete(Komentar komentar)
        {
            _collection.Remove(komentar);
            await _context.SaveChangesAsync();
        }


    }
}
