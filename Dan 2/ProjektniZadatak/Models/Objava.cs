﻿using ProjektniZadatak.Controllers.Model;

namespace ProjektniZadatak.Models
{
    public class Objava
    {
        public int Id { get; set; }

        public string Tekst { get; set; }

        public int KorisnikId { get; set; }

        public List<Komentar> SviKomentari { get; set; }

        public Korisnik Autor { get; set; }

        public List<Lajk> SviLajkovi { get; set; }
    }
}