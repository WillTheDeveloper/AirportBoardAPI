using System.Data;
using AirportBoardAPI.Models;
using Dapper;

namespace AirportBoardAPI.Data
{
	public class FlightData : IFlightData
	{
		readonly Context _context;

		public FlightData(Context context)
		{
			_context = context;
		}

		public async Task<Flight> FlightDetail(int id)
		{
			var data = new Flight();
			try
			{
				var parameters = new DynamicParameters();
				parameters.Add("FlightId", id);
				data = await _context.Connection.QueryFirstAsync<Flight>("pFlight", parameters, commandType: CommandType.StoredProcedure);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				throw;
			}

			return data;
		}
	}
}
