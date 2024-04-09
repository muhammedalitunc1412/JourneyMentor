using JourneyMentor.Application.Interfaces.RedisCache;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyMentor.Application.Features.Flights.Queries.GetAllFlights
{
    public class GetAllFlightsQueryRequest : IRequest<IList<GetAllFlightsQueryResponse>>, ICacheableQuery
    {
        public string CacheKey => throw new NotImplementedException();

        public double CacheTime => throw new NotImplementedException();
    }
}
