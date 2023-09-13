using Microsoft.EntityFrameworkCore;
using ProjektniZadatak.Controllers.Model;

namespace ProjektniZadatak.Repository
{
    public interface IKorisnikRepository
    {
        Korisnik GetById(int id);
        IEnumerable<Korisnik> GetAll();
        void Create(Korisnik user);
        void Update(Korisnik user);
        void Delete(Korisnik user);
    }

    public class KorisnikRepository : IKorisnikRepository
    {
        private readonly DrustvenaMrezaDbContext _context;

        public KorisnikRepository(DrustvenaMrezaDbContext context)
        {
            _context = context;
        }

        public Korisnik GetById(int id)
        {
            return _context.Korisnici.Find(id);
        }

        public IEnumerable<Korisnik> GetAll()
        {
            return _context.Korisnici.ToList();
        }

        public void Create(Korisnik user)
        {
            _context.Korisnici.Add(user);
            _context.SaveChanges();
        }

        public void Update(Korisnik user)
        {
            _context.Korisnici.Entry(user).State = EntityState.Modified;
            //ovo gore je dosta cistije, update ako entitet ne postoji pokusa da ga unese..  _context.Korisnici.Update(user);
            _context.SaveChanges();
        }

        public void Delete(Korisnik user)
        {
            _context.Korisnici.Remove(user);
            _context.SaveChanges();
        }
    }

}
