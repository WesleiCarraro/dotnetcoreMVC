using ForecastApp.OpenWeatherMapModels;


namespace ForecastApp.Repositories
{
    public interface IForecastRepository
    {
        WeatherResponse GetForecast(string city);
    }
}
