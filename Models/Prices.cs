namespace FlightSearchAssingment.Models
{
	public class Prices
	{
		public int PricesId { get; set; }
		public string Currency { get; set; }
		public int AdultPrice { get; set; }
		public int ChildPrice { get; set; }
		public List<Itenerary> Iteneraties { get; set; }
	}
}