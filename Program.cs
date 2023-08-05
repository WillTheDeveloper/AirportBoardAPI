using AirportBoardAPI;
using AirportBoardAPI.Data;
using AirportBoardAPI.Endpoints;
using AirportBoardAPI.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<Context>();

builder.Services.AddScoped<IFlightService, FlightService>();

builder.Services.AddScoped<IFlightData, FlightData>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.MapFlightEndpoints();

app.UseHttpsRedirection();

app.Run();
