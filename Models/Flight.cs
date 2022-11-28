namespace FlightSearchAssingment.Models
{
	public class Flight
	{

		public int FlightId { get; set; }
		public string Departure { get; set; }
		public string Arrival { get; set; }
		public List<Itenerary> Iteneraries { get; set; }

	}
}
