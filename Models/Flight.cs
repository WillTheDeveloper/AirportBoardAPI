namespace AirportBoardAPI.Models
{
	public class Flight
	{
		public int FlightId { get; set; }
		public string Departure { get; set; }
		public string Destination { get; set; }
		public DateTime DepartureTime { get; set; }
		public DateTime ArrivalTime { get; set; }
		public string Gate { get; set; }
		public int Terminal { get; set; }
		public int Passengers { get; set; }
		public int Suitcases { get; set; }
		public int Weight { get; set; }
	}
}
