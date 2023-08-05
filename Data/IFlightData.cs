using AirportBoardAPI.Models;

namespace AirportBoardAPI.Data
{
	public interface IFlightData
	{
		Task<Flight> FlightDetail(int id);
	}
}
