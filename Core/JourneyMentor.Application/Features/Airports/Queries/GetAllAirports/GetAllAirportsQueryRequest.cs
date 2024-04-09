using JourneyMentor.Application.Features.Flights.Queries.GetAllFlights;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyMentor.Application.Features.Airports.Queries.GetAllAirports
{
    public class GetAllAirportsQueryRequest: IRequest<IList<GetAllAirportsQueryResponse>>
    {
    }
}
