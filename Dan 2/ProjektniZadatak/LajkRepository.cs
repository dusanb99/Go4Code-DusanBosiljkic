using ProjektniZadatak.Models;

namespace ProjektniZadatak
{
    public interface ILajkRepository
    {
        Lajk getById (int id);

        IEnumerable<Lajk> getAll();

        void Create (Lajk lajk);

        void Update (Lajk lajk);

        void Delete (Lajk lajk);




    }

    public class LajkRepository : ILajkRepository
    {
        private readonly DrustvenaMrezaDbContext _context;
        public LajkRepository (DrustvenaMrezaDbContext context)
        {
            _context = context;
        }

        public Lajk getById (int id)
        {
            return _context.Lajkovi.Find(id);
        }

        public IEnumerable<Lajk> getAll()
        {
            return _context.Lajkovi.ToList(); 
        }

        public void Create (Lajk lajk)
        {
            _context.Lajkovi.Add(lajk);
            _context.SaveChanges();
        }

        public void Update (Lajk lajk)
        {
            _context.Lajkovi.Update(lajk);
            _context.SaveChanges();
        }

        public void Delete (Lajk lajk)
        {
            _context.Lajkovi.Remove(lajk);
            _context.SaveChanges();
        }
    }
}
