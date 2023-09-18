using Microsoft.EntityFrameworkCore;
using ProjektniZadatak.Models;
using ProjektniZadatak.Models.DTO;
using System.Diagnostics.Contracts;

namespace ProjektniZadatak.Repository
{
    

    public class ObjavaRepository : IObjavaRepository
    {
        private readonly DrustvenaMrezaDbContext _context;

        public readonly DbSet<Objava> _collection;

        public ObjavaRepository(DrustvenaMrezaDbContext context)
        {
            _context = context;

            _collection = _context.Objave;
        }

        public async Task<Objava> Get (int id)
        {
            return await _collection.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Objava>> GetAll ()
        {
            return await _collection.AsNoTracking().ToListAsync();
        }

        public async Task<Objava> Create (Objava objava)
        {
            await _collection.AddAsync(objava);
            await _context.SaveChangesAsync();

            return objava;
        }

        public async Task Delete(Objava objava)
        {
            _collection.Remove(objava);
            await _context.SaveChangesAsync();
        }

        public async Task<Objava> UpdateAsync(int id, Objava updatedObjava)
        {
            var existingObjava = await _context.Objave.FindAsync(id);

            if (existingObjava == null)
            {
                return null; // Objava sa datim ID-om nije pronađena
            }

            // Ažurirajte polja objave prema updatedObjava
            existingObjava.Naslov = updatedObjava.Naslov;
            existingObjava.Tekst = updatedObjava.Tekst;
            // Dodajte ostala polja koja želite ažurirati

            await _context.SaveChangesAsync();
            return existingObjava; // Vratite ažuriranu objavu
        }


    }
}
