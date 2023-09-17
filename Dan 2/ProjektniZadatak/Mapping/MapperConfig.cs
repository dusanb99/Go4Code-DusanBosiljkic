using AutoMapper;
using ProjektniZadatak.Controllers.Model;
using ProjektniZadatak.Models.DTO;
using ProjektniZadatak.Models;

namespace ProjektniZadatak.Mapping
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Korisnik, KorisniciCreateRequest>().ReverseMap();
            CreateMap<Korisnik, KorisniciGetDetailsResponse>().ReverseMap();

            CreateMap<Objava, ObjaveCreateRequest>().ReverseMap();
            CreateMap<Objava, ObjaveGetDetailsResponse>().ReverseMap();

            CreateMap<Lajk, LajkCreateRequest>().ReverseMap();
            CreateMap<Lajk, LajkGetDetailsResponse>().ReverseMap();

            CreateMap<Komentar, KomentarCreateRequest>().ReverseMap();
            CreateMap<Komentar, KomentarGetDetailsResponse>().ReverseMap();

            CreateMap<Obavestenje, ObavestenjeGetDetailsResponse>().ReverseMap();

            CreateMap<Pratilac, PratilacCreateRequest>().ReverseMap();
            CreateMap<Pratilac, PratilacGetDetailsResponse>().ReverseMap();
        }
    }
}
