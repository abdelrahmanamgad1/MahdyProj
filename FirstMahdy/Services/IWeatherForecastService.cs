using FirstMahdy.Services;

namespace FirstMahdy;

public interface IWeatherForecastService 
{
    IEnumerable<WeatherForecast> GetForecasts();
}
