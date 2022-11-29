using FlightSearchAssingment.Data;
using FlightSearchAssingment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Core.Objects;

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
		public async Task<ActionResult<IEnumerable<Flight>>> Search (FlightSearchDTO flightSearchDTO)
		{
			var res = await _context.Flights.
			Where(x =>
			x.Departure.Contains(flightSearchDTO.DepartureDestination) &&
			x.Arrival.Contains(flightSearchDTO.ArrivalDestination))
			.Include(
				flight => flight.Iteneraries.
				Where(i =>
				EntityFunctions.TruncateTime(i.DepartureTime) == EntityFunctions.TruncateTime(flightSearchDTO.DepartureDate) &&
				EntityFunctions.TruncateTime(i.ArrivalTime) == EntityFunctions.TruncateTime(flightSearchDTO.ArrivalDate)))
			.ToListAsync();
			if ( flightSearchDTO.RoundTrip == false )
			{
				return Ok(res);
			}

			foreach ( Flight flight in res )
			{


			}
		}

		private bool FlightExists (string id)
		{
			return _context.Flights.Any(e => e.FlightId == id);
		}
	}
}
