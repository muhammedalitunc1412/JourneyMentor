using JourneyMentor.Application.Bases;
using JourneyMentor.Application.DTOs;
using JourneyMentor.Application.Features.Airports.Command;
using JourneyMentor.Application.Interfaces.AutoMapper;
using JourneyMentor.Application.Interfaces.UnitOfWorks;
using JourneyMentor.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyMentor.Application.Features.Flights.Command
{
    public class İmportFlightCommandHandler : BaseHandler, IRequestHandler<İmportFlightCommandRequest, Unit>
    {
        public İmportFlightCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            unitOfWork = this.unitOfWork;
        }
        public async Task<Unit> Handle(İmportFlightCommandRequest request, CancellationToken cancellationToken)
        {
            var flights = await unitOfWork.GetReadRepository<Flight>().GetAllDataFromAvitionStackAsyn(AviationStackDataForFlights.ApiUrl, AviationStackDataForFlights.AccessKey);

            if (flights is not null)
            {
                await unitOfWork.GetWriteRepository<Flight>().ImportGenericAviationStackDataAsync(flights);
            }
            if (await unitOfWork.SaveAsync() > 0)
            {
                await unitOfWork.SaveAsync();
            }
            return Unit.Value;
        }
    }
}
