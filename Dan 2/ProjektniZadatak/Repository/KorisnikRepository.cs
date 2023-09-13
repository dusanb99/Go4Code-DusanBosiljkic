using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjektniZadatak.Controllers.Model;
using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Repository
{
    

    public class KorisnikRepository : IKorisnikRepository
    {
        private readonly DrustvenaMrezaDbContext _context;
        private readonly IMapper _mapper;

        public KorisnikRepository(DrustvenaMrezaDbContext context)
        {
            _context = context;
        }

        public KorisnikDTO GetById(int id)
        {
            try
            {
                var korisnikEntity = _context.Korisnici.FirstOrDefault(x => x.Id == id);
                return _mapper.Map<KorisnikDTO>(korisnikEntity);
            }

            catch (Exception e)
            {
                return null;
            }
        }

        public List<KorisnikDTO> GetAll()
        {
            return _mapper.Map<List<KorisnikDTO>>(_context.Korisnici.ToList());
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
