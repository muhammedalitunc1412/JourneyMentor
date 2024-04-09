using JourneyMentor.Application.Interfaces.AutoMapper;
using JourneyMentor.Application.Interfaces.UnitOfWorks;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyMentor.Application.Features.Flights.Queries.GetAllFlights
{
    internal class GetAllFlightsQueryHandler : IRequestHandler<GetAllFlightsQueryRequest, IList<GetAllFlightsQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAllFlightsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public Task<IList<GetAllFlightsQueryResponse>> Handle(GetAllFlightsQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
