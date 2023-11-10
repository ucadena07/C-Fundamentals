using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SomethingElse;

internal interface IWeatherForecastClient
{
    Task<List<WeatherForecast>> GetAll();
}
internal class WeatherForecastClient : IWeatherForecastClient
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl = "http://localhost:5022/WeatherForecast/";

    public WeatherForecastClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<List<WeatherForecast>> GetAll()
    {
        var response = await _httpClient.GetFromJsonAsync<List<WeatherForecast>>(_baseUrl);
        if(response is null)
        {
            return new();
        }
        return response;
    }

}
