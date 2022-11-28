using Newtonsoft.Json;

namespace FlightSearchAssingment.Models
{
	public class Flight
	{
		[JsonProperty("flight_id")]
		public string FlightId { get; set; }

		[JsonProperty("depatureDestination")]
		public string Departure { get; set; }
		[JsonProperty("arrivalDestination")]
		public string Arrival { get; set; }
		[JsonProperty("itineraries")]
		public List<Itenerary> Iteneraries { get; set; }

	}
}
