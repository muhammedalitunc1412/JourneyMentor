using JourneyMentor.Application.DTOs;
using JourneyMentor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyMentor.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryResponse
    {
        public string? FlightDate { get; set; }
        public string? FlightStatus { get; set; }
        public string? DepartureAirport { get; set; }
        public string? DepartureTimezone { get; set; }
        public string? DepartureIata { get; set; }
        public string? DepartureIcao { get; set; }
        public string? DepartureTerminal { get; set; }
        public string? DepartureGate { get; set; }
        public int? DepartureDelay { get; set; }
        public string? DepartureScheduled { get; set; }
        public string? DepartureEstimated { get; set; }
        public string? DepartureActual { get; set; }
        public string? DepartureEstimatedRunway { get; set; }
        public string? DepartureActualRunway { get; set; }
        public string? ArrivalAirport { get; set; }
        public string? ArrivalTimezone { get; set; }
        public string? ArrivalIata { get; set; }
        public string? ArrivalIcao { get; set; }
        public string? ArrivalTerminal { get; set; }
        public string? ArrivalGate { get; set; }
        public string? ArrivalBaggage { get; set; }
        public int? ArrivalDelay { get; set; }
        public string? ArrivalScheduled { get; set; }
        public string? ArrivalEstimated { get; set; }
        public string? ArrivalActual { get; set; }
        public string? ArrivalEstimatedRunway { get; set; }
        public string? ArrivalActualRunway { get; set; }
        public string? AirlineName { get; set; }
        public string? AirlineIata { get; set; }
        public string? AirlineIcao { get; set; }
        public string? FlightNumber { get; set; }
        public string? FlightIata { get; set; }
        public string? FlightIcao { get; set; }
        public string? AircraftRegistration { get; set; }
        public string? AircraftIata { get; set; }
        public string? AircraftIcao { get; set; }
        public string? AircraftIcao24 { get; set; }
        public string? LiveUpdated { get; set; }
        public float? LiveLatitude { get; set; }
        public float? LiveLongitude { get; set; }
        public float? LiveAltitude { get; set; }
        public float? LiveDirection { get; set; }
        public float? LiveSpeedHorizontal { get; set; }
        public float? LiveSpeedVertical { get; set; }
        public bool LiveIsGround { get; set; }
    }
}
