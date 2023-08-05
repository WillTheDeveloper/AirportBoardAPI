using AirportBoardAPI.Data;
using AirportBoardAPI.Models;

namespace AirportBoardAPI.Service
{
	public class FlightService : IFlightService
	{
		private readonly IFlightData _data;

		public FlightService(IFlightData flightData)
		{
			_data = flightData;
		}

		public async Task<Flight> FlightDetail(int id)
		{
			return await _data.FlightDetail(id);
		}
	}
}
