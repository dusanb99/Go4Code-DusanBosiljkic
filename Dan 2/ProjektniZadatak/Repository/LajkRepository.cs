using AutoMapper;
using ProjektniZadatak.Models;

namespace ProjektniZadatak.Repository
{
    

    public class LajkRepository : ILajkRepository
    {
        private readonly DrustvenaMrezaDbContext _context;
        private readonly IMapper _mapper;
        public LajkRepository(DrustvenaMrezaDbContext context)
        {
            _context = context;
        }

        

        public IEnumerable<Lajk> getAll()
        {
            return _context.Lajkovi.ToList();
        }

        public void Create(Lajk lajk)
        {
            _context.Lajkovi.Add(lajk);
            _context.SaveChanges();
        }

        public void Update(Lajk lajk)
        {
            _context.Lajkovi.Update(lajk);
            _context.SaveChanges();
        }

        public void Delete(Lajk lajk)
        {
            _context.Lajkovi.Remove(lajk);
            _context.SaveChanges();
        }
    }
}
