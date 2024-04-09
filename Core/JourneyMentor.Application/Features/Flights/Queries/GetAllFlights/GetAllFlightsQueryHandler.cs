using JourneyMentor.Application.Features.Products.Queries.GetAllProducts;
using JourneyMentor.Application.Interfaces.AutoMapper;
using JourneyMentor.Application.Interfaces.UnitOfWorks;
using JourneyMentor.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyMentor.Application.Features.Flights.Queries.GetAllFlights
{
    public class GetAllFlightsQueryHandler : IRequestHandler<GetAllFlightsQueryRequest, IList<GetAllFlightsQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAllFlightsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IList<GetAllFlightsQueryResponse>> Handle(GetAllFlightsQueryRequest request, CancellationToken cancellationToken)
        {
            var flights = await unitOfWork.GetReadRepository<Flight>().GetAllAsync();
            var map = mapper.Map<GetAllFlightsQueryResponse, Flight>(flights);
            return map;
        }
    }
}
