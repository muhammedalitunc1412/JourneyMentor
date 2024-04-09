using JourneyMentor.Application.Bases;
using JourneyMentor.Application.DTOs;
using JourneyMentor.Application.Features.Products.Command.CreateProduct;
using JourneyMentor.Application.Features.Products.Rules;
using JourneyMentor.Application.Interfaces.AutoMapper;
using JourneyMentor.Application.Interfaces.UnitOfWorks;
using JourneyMentor.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyMentor.Application.Features.Airports.Command
{
    public class İmportAirportCommandHandler : BaseHandler, IRequestHandler<İmportAirportCommandRequest, Unit>
    {

        public İmportAirportCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            unitOfWork=this.unitOfWork;
        }
        public async Task<Unit> Handle(İmportAirportCommandRequest request, CancellationToken cancellationToken)
        {

            var airports = await unitOfWork.GetReadRepository<Airport>().GetAllDataFromAvitionStackAsyn(AviationStackDataForAirport.ApiUrl, AviationStackDataForAirport.AccessKey);

            if (airports is not null) 
            {
                await unitOfWork.GetWriteRepository<Airport>().ImportGenericAviationStackDataAsync(airports);
            }
            if (await unitOfWork.SaveAsync() > 0)
            {
                await unitOfWork.SaveAsync();
            }
            return Unit.Value;
        }
    }
}
