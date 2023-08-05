using System.Reflection.Metadata.Ecma335;
using AirportBoardAPI.Service;
using Microsoft.AspNetCore.Mvc;

namespace AirportBoardAPI.Endpoints
{
	public static class FlightEndpoints
	{
		public static void MapFlightEndpoints(this WebApplication app)
		{
			app.MapGet("/api/flight/{id}", async (
						[FromServices] IFlightService service,
						[FromRoute] int id) =>
					Results.Ok(await service.FlightDetail(id)))
				.WithTags("Flights");
		}
	}
}
