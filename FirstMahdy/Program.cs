using FirstMahdy;
using FirstMahdy.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthorization();
builder.Services.AddControllers();

builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// app.MapGet("/weatherforecast", () =>
// {
//     var service = new WeatherForecastService(new Logger<WeatherForecastService>(new LoggerFactory()));
//     return service.GetForecasts();
// })
// .WithName("GetWeatherForecast")
// .WithOpenApi();

app.Run();

