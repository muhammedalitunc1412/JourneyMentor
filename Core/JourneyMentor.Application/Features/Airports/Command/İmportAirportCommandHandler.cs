using JourneyMentor.Application.Bases;
using JourneyMentor.Application.DTOs;
using JourneyMentor.Application.Features.Products.Command.CreateProduct;
using JourneyMentor.Application.Features.Products.Rules;
using JourneyMentor.Application.Interfaces.AutoMapper;
using JourneyMentor.Application.Interfaces.UnitOfWorks;
using MediatR;
using Microsoft.AspNetCore.Http;
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
            
        }
        public Task<Unit> Handle(İmportAirportCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
