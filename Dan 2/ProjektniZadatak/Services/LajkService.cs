using AutoMapper;
using ProjektniZadatak.Models.DTO;
using ProjektniZadatak.Repository;

namespace ProjektniZadatak.Services

{
    



        public class LajkService : ILajkService

        {
            private readonly ILajkRepository _lajkRepository;
            private readonly IMapper _mapper;

            public LajkService(ILajkRepository lajkRepository, IMapper mapper)
            {
                _lajkRepository = lajkRepository;
                _mapper = mapper;
            }

            

        }
    }

