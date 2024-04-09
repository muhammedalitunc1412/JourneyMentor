using JourneyMentor.Application.Features.Airports.Command;
using JourneyMentor.Application.Features.Airports.Queries.GetAllAirports;
using JourneyMentor.Application.Features.Products.Command.CreateProduct;
using JourneyMentor.Application.Features.Products.Queries.GetAllProducts;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JourneyMentor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private readonly IMediator mediator;
        public AirportController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAirports()
        {
            var response = await mediator.Send(new GetAllAirportsQueryRequest());

            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> ImportFlights(İmportAirportCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }
    }
}
