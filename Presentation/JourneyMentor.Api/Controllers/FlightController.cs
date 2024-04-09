using JourneyMentor.Application.Features.Airports.Command;
using JourneyMentor.Application.Features.Airports.Queries.GetAllAirports;
using JourneyMentor.Application.Features.Flights.Command;
using JourneyMentor.Application.Features.Flights.Queries.GetAllFlights;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JourneyMentor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class FlightController : ControllerBase
    {
        private readonly IMediator mediator;

        public FlightController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllFlights()
        {
            var response = await mediator.Send(new GetAllFlightsQueryRequest());

            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> ImportFlights(İmportFlightCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }
    }
}
