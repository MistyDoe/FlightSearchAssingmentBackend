using FlightSearchAssingment.Data;
using FlightSearchAssingment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlightSearchAssingment.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FlightsController : ControllerBase
	{
		private readonly DataContext _context;

		public FlightsController (DataContext context)
		{
			_context = context;
		}

		// GET: api/Flights
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Flight>>> Search ([FromQuery] FlightSearchDTO flightSearchDTO)
		{
			var res = await _context.Flights.
			Where(x =>
			x.Departure.Contains(flightSearchDTO.DepartureDestination) &&
			x.Arrival.Contains(flightSearchDTO.ArrivalDestination))
			.Include(
				flight => flight.Iteneraries.
				Where(i =>
				(i.DepartureTime.Date == flightSearchDTO.DepartureDate.Date) &&
				(i.ArrivalTime.Date == flightSearchDTO.ArrivalDate.Date)))
			.ToListAsync();
			if ( flightSearchDTO.RoundTrip == false )
			{
				return Ok(res);
			}
			var returnres = new List<Flight>();

			foreach ( Flight flight in res )
			{
				Flight flightretrun = await _context.Flights
					.Where(
			x =>
			x.Departure.Contains(flightSearchDTO.ArrivalDestination) &&
			x.Arrival.Contains(flightSearchDTO.DepartureDestination))
				.Include(f => f.Iteneraries)
					.ThenInclude(x =>
				(x.DepartureTime.Date == flightSearchDTO.RetrunDepartureDate.Date) &&
				(x.ArrivalTime.Date) == (flightSearchDTO.RetrunArrivalDate)).
				FirstOrDefaultAsync();
				res.Add(flightretrun);
			}
			return Ok(res);
		}

		private bool FlightExists (string id)
		{
			return _context.Flights.Any(e => e.FlightId == id);
		}
	}
}
