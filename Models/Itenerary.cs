using Newtonsoft.Json;

namespace FlightSearchAssingment.Models
{
	public class Itenerary
	{
		public string IteneraryID { get; set; }
		public Flight Flight { get; set; }

		[JsonProperty("depatureAt")]
		public DateTime DepartureTime { get; set; }
		[JsonProperty("arriveAt")]
		public DateTime ArrivalTime { get; set; }
		[JsonProperty("avaliableSeats")]
		public int AvailableSeats { get; set; }
		[JsonProperty("prices")]
		public ICollection<Prices> PriceList { get; set; }
	}
}
