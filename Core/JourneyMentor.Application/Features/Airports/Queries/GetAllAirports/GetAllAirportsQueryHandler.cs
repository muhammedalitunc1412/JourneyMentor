using JourneyMentor.Application.Features.Flights.Queries.GetAllFlights;
using JourneyMentor.Application.Interfaces.AutoMapper;
using JourneyMentor.Application.Interfaces.UnitOfWorks;
using JourneyMentor.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyMentor.Application.Features.Airports.Queries.GetAllAirports
{
    public class GetAllAirportsQueryHandler : IRequestHandler<GetAllAirportsQueryRequest, IList<GetAllAirportsQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAllAirportsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IList<GetAllAirportsQueryResponse>> Handle(GetAllAirportsQueryRequest request, CancellationToken cancellationToken)
        {
            var airports = await unitOfWork.GetReadRepository<Airport>().GetAllAsync();
            var map = mapper.Map<GetAllAirportsQueryResponse, Airport>(airports);
            return map;
        }
    }
}