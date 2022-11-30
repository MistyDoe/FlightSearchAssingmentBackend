using System.ComponentModel.DataAnnotations;

namespace FlightSearchAssingment.DTOs
{
    public class FlightSearchDTO
    {
        public string departureDestination { get; set; }
        public string arrivalDestination { get; set; }
        public bool roundTrip { get; set; }
        public int adults { get; set; }
        public int children { get; set; }
        [DataType(DataType.Date)]
        public DateTime departureDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime retrunDepartureDate { get; set; }

    }
}
