using AirportBoardAPI.Models;

namespace AirportBoardAPI.Service
{
	public interface IFlightService
	{
		Task<Flight> FlightDetail(int id);
	}
}
