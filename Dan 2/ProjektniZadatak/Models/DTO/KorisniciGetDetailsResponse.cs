﻿namespace ProjektniZadatak.Models.DTO
{
    public class KorisniciGetDetailsResponse
    {
        public int Id {  get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }
    }
}
