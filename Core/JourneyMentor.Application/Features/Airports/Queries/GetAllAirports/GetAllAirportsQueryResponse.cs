using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyMentor.Application.Features.Airports.Queries.GetAllAirports
{
    public class GetAllAirportsQueryResponse
    {
        public string Gmt { get; set; }

        public int? AirportId { get; set; }

        public string IataCode { get; set; }

        public string CityIataCode { get; set; }

        public string IcaoCode { get; set; }

        public string CountryIso2 { get; set; }

        public string GeonameId { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string AirportName { get; set; }

        public string CountryName { get; set; }

        public string? PhoneNumber { get; set; }

        public string Timezone { get; set; }
    }
}
