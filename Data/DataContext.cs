using FlightSearchAssingment.Models;
using Microsoft.EntityFrameworkCore;

namespace FlightSearchAssingment.Data
{
	public class DataContext : DbContext
	{

		public DataContext (DbContextOptions<DataContext> options) : base(options)
		{
		}

		public DbSet<Flight> Flights { get; set; }
		public DbSet<Itenerary> Iteneraries { get; set; }
		public DbSet<Prices> PriceList { get; set; }
	}


}
