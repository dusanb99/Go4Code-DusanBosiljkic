using Microsoft.EntityFrameworkCore;
using ProjektniZadatak.Models;
using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Repository
{
    

    public class ObjavaRepository : IObjavaRepository
    {
        private readonly DrustvenaMrezaDbContext _context;

        public readonly DbSet<Objava> _collection;

        public ObjavaRepository(DrustvenaMrezaDbContext context)
        {
            _context = context;
        }

        public Objava getById(int id)
        {
            try
            {
                var result = _context.Objave.FirstOrDefault(x => x.Id == id);
                return result;
            }

            catch(Exception ex)
            {
                return null;
            }
            
        }

        public IEnumerable<Objava> GetAll()
        {
            return _context.Objave.ToList();
        }

        public void Create(Objava objava)
        {
            _context.Objave.Add(objava);
            _context.SaveChanges();
        }

        public void Delete(Objava objava)
        {
            _context?.Objave.Remove(objava);
            _context.SaveChanges();
        }

        public void Update(Objava objava)
        {
            _context.Objave.Update(objava);
            _context.SaveChanges();
        }

        List<ObjavaDTO> IObjavaRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
