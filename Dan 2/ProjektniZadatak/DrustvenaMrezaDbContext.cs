using Microsoft.EntityFrameworkCore;
using ProjektniZadatak.Controllers.Model;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ProjektniZadatak.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ProjektniZadatak
{
    public class DrustvenaMrezaDbContext : DbContext
    {


        public DrustvenaMrezaDbContext(DbContextOptions<DrustvenaMrezaDbContext> options) : base(options) {}

       public DbSet<Korisnik> Korisnici { get; set; }

       public  DbSet<Komentar> Komentari { get; set; }

       public  DbSet<Lajk> Lajkovi { get; set; }

       public  DbSet<Objava> Objave { get; set; }

       public DbSet<Obavestenje> Obavestenja { get; set; }

       public DbSet<Pratilac> Pratioci { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Konfiguracija veze između Korisnika i Pratilaca
            modelBuilder.Entity<Pratilac>()
                .HasOne(p => p.PratilacKorisnika)
                .WithMany(u => u.Pratioci)
                .HasForeignKey(p => p.PratilacId)
                .OnDelete(DeleteBehavior.Restrict); // Opciono: postavite brisanje na Restrict ako želite zabraniti brisanje korisnika sa pratilcima.

            modelBuilder.Entity<Pratilac>()
                .HasOne(p => p.PraceniKorisnik)
                .WithMany()
                .HasForeignKey(p => p.PraceniKorisnikId)
                .OnDelete(DeleteBehavior.Restrict); // Opciono: postavite brisanje na Restrict ako želite zabraniti brisanje korisnika sa pratilcima.

            base.OnModelCreating(modelBuilder);
        }





    }
}
