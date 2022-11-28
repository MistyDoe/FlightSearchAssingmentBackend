using Newtonsoft.Json;

namespace FlightSearchAssingment.Models
{
	public class Itenerary
	{
		public string IteneraryID { get; set; }
		public Flight flight { get; set; }

		[JsonProperty("depatureAt")]
		public DateTime DepartureTime { get; set; }
		[JsonProperty("arriveAt")]
		public DateTime ArrivalTime { get; set; }
		[JsonProperty("avaliableSeats")]
		public int AvailableSeats { get; set; }
		[JsonProperty("prices")]
		public Prices[] PriceList { get; set; }
	}
}
