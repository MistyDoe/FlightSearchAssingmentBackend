namespace FlightSearchAssingment.Models
{
	public class Itenerary
	{
		public int IteneraryID { get; set; }
		public DateTime DepartureTime { get; set; }
		public DateTime ArrivalTime { get; set; }
		public int AvailableSeats { get; set; }
		public Flight flight { get; set; }
		public Prices PriceList { get; set; }
	}
}
