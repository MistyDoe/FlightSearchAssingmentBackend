using FlightSearchAssingment.Data;
using FlightSearchAssingment.DTOs;
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
		public async Task<ActionResult<IEnumerable<Flight>>> Search ([FromHeader] FlightSearchDTO flightSearchDTO)
		{
			var res = await _context.Flights.
			Where(x =>
			x.Departure.Contains(flightSearchDTO.departureDestination))
			.Include(
				flight => flight.Iteneraries.
				Where(i =>
				(i.DepartureTime.Date.ToString().Contains(flightSearchDTO.departureDate.Date.ToString()))
				 &&
				(i.AvailableSeats >= flightSearchDTO.adults + flightSearchDTO.children)))
			.ThenInclude(
				itenerary => itenerary.PriceList)
			.ToListAsync();
			if ( flightSearchDTO.roundTrip == false )
			{
				return Ok(res);
			}
			var returnres = new List<Flight>();

			foreach ( Flight flight in res.ToList() )
			{
				Flight flightretrun = await _context.Flights
					.Where(x =>
					x.Departure.Contains(flightSearchDTO.arrivalDestination)
					&& x.Arrival.Contains(flightSearchDTO.departureDestination))
							.Include(f => f.Iteneraries
								.Where(x =>
								x.DepartureTime.Date.ToString().Contains(flightSearchDTO.retrunDepartureDate.Date.ToString())
									))
									.FirstOrDefaultAsync();
				returnres.Add(flightretrun);
			}
			return Ok(res.Concat(returnres));
		}
		[HttpPatch]
		public async Task<ActionResult<IEnumerable<Itenerary>>> UpdateSeatsLeft (string iteneraryId, int TotalPassangers)
		{
			Itenerary iteneraryToUpdate = await _context.Iteneraries.FirstOrDefaultAsync(x => x.IteneraryID == iteneraryId);
			iteneraryToUpdate.AvailableSeats -= TotalPassangers;
			_context.Update(iteneraryToUpdate);
			_context.SaveChanges();
			return Ok(iteneraryToUpdate);
		}
	}
}
