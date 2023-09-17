﻿using Microsoft.EntityFrameworkCore;
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

        public void Update(Objava objava)
        {
            _context.Objave.Entry(objava).State = EntityState.Modified;
            _context.SaveChanges();
        }

        
    }
}
