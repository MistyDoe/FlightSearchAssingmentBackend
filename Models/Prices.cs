using Newtonsoft.Json;

namespace FlightSearchAssingment.Models
{
	public class Prices
	{
		public string PricesId { get; set; }
		public string IteneraryID { get; set; }
		[JsonProperty("currency")]
		public string Currency { get; set; }
		[JsonProperty("adult")]
		public int AdultPrice { get; set; }
		[JsonProperty("child")]
		public int ChildPrice { get; set; }
	}
}