using ProjektniZadatak.Models;

namespace ProjektniZadatak
{
    public interface IObjavaRepository
    {
        Objava getById(int id);

        IEnumerable<Objava> GetAll();

        void Create(Objava objava);

        void Update(Objava objava);

        void Delete(Objava objava);


    }

    public class ObjavaRepository : IObjavaRepository
    {
        private readonly DrustvenaMrezaDbContext _context;

        public ObjavaRepository(DrustvenaMrezaDbContext context)
        {
            _context = context;
        }

        public Objava getById(int id)
        {
            return _context.Objave.Find(id);
        }

        public IEnumerable<Objava> GetAll()
        {
            return _context.Objave.ToList();
        }

        public void Create (Objava objava)
        {
            _context.Objave.Add(objava);
            _context.SaveChanges();
        }

        public void Delete (Objava objava)
        {  
            _context?.Objave.Remove(objava);
            _context.SaveChanges();
        }

        public void Update (Objava objava)
        {
            _context.Objave.Update(objava);
            _context.SaveChanges();
        }
    }
}
