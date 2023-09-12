using Microsoft.EntityFrameworkCore;
using ProjektniZadatak.Controllers.Model;
using ProjektniZadatak.Models;

namespace ProjektniZadatak
{
    public class DrustvenaMrezaDbContext : DbContext
    {


        public DrustvenaMrezaDbContext(DbContextOptions<DrustvenaMrezaDbContext> options) : base(options) 
        {
        }

       public DbSet<Korisnik> Korisnici { get; set; }
       public  DbSet<Komentar> Komentari { get; set; }

       public  DbSet<Lajk> Lajkovi { get; set; }

       public  DbSet<Objava> Objave { get; set; }


        


    }
}
