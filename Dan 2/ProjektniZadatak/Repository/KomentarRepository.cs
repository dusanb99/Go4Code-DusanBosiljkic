using ProjektniZadatak.Models;
using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Repository
{
    

    public class KomentarRepository : IKomentarRepository
    {
        private readonly DrustvenaMrezaDbContext _context;

        public KomentarRepository(DrustvenaMrezaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Komentar> getAll()
        {
            return _context.Komentari.ToList();
        }

        

        public IEnumerable<Komentar> GetAll()
        {
            return _context.Komentari.ToList();
        }

        public void Create(Komentar komentar)
        {
            _context.Komentari.Add(komentar);
            _context.SaveChanges();
        }

        public void Update(Komentar komentar)
        {
            _context.Komentari.Update(komentar);
            _context.SaveChanges();
        }


        public void Delete(Komentar komentar)
        {
            _context.Komentari.Remove(komentar);
            _context.SaveChanges();
        }
    }
}
