using AutoMapper;
using ProjektniZadatak.Controllers.Model;
using ProjektniZadatak.Models.DTO;

namespace ProjektniZadatak.Mapping


{
    public class MapperConfig : Profile
    {

        public MapperConfig() 
        {
            CreateMap<Korisnik, KorisniciCreateRequest>().ReverseMap();
            CreateMap<Korisnik, KorisniciGetDetailsResponse>().ReverseMap();
        }
    }
}
