using Entities;
using Microsoft.Extensions.DependencyInjection;
using SomethinElse;
using SomethingElse;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Text.Json;
using static System.Net.WebRequestMethods;

var httpClient = new HttpClient();
var url = "http://localhost:5022/WeatherForecast";


//Example 1: Using GetAsync
var response = await httpClient.GetAsync(url) ;
var body = await response.Content.ReadAsStringAsync();

//Console.WriteLine("--Response's body--");
//Console.WriteLine(body);

//Console.WriteLine("--Response's headers--");
foreach (var header in response.Headers)
{
    //Console.WriteLine($"{header.Key}: {header.Value.First()}");
}

//Example 2: Using GetStringAsync
//var responseBody = await httpClient.GetStringAsync(url);
//Console.WriteLine(responseBody);

//Example 3: was the request successful
if (response.IsSuccessStatusCode)
{
    //Console.WriteLine("Success");
}
else
{
    //Console.WriteLine("nope");
}

//Example 4: specific action depenending on status
switch (response.StatusCode)
{
    case System.Net.HttpStatusCode.Continue:
        break;
    case System.Net.HttpStatusCode.SwitchingProtocols:
        break;
    case System.Net.HttpStatusCode.Processing:
        break;
    case System.Net.HttpStatusCode.EarlyHints:
        break;
    case System.Net.HttpStatusCode.OK:
        break;
    case System.Net.HttpStatusCode.Created:
        break;
    case System.Net.HttpStatusCode.Accepted:
        break;
    case System.Net.HttpStatusCode.NonAuthoritativeInformation:
        break;
    case System.Net.HttpStatusCode.NoContent:
        break;
    case System.Net.HttpStatusCode.ResetContent:
        break;
    case System.Net.HttpStatusCode.PartialContent:
        break;
    case System.Net.HttpStatusCode.MultiStatus:
        break;
    case System.Net.HttpStatusCode.AlreadyReported:
        break;
    case System.Net.HttpStatusCode.IMUsed:
        break;
    case System.Net.HttpStatusCode.Ambiguous:
        break;

    case System.Net.HttpStatusCode.Moved:
        break;

    case System.Net.HttpStatusCode.Found:
        break;

    case System.Net.HttpStatusCode.RedirectMethod:
        break;

    case System.Net.HttpStatusCode.NotModified:
        break;
    case System.Net.HttpStatusCode.UseProxy:
        break;
    case System.Net.HttpStatusCode.Unused:
        break;
    case System.Net.HttpStatusCode.RedirectKeepVerb:
        break;
    case System.Net.HttpStatusCode.PermanentRedirect:
        break;
    case System.Net.HttpStatusCode.BadRequest:
        break;
    case System.Net.HttpStatusCode.Unauthorized:
        break;
    case System.Net.HttpStatusCode.PaymentRequired:
        break;
    case System.Net.HttpStatusCode.Forbidden:
        break;
    case System.Net.HttpStatusCode.NotFound:
        break;
    case System.Net.HttpStatusCode.MethodNotAllowed:
        break;
    case System.Net.HttpStatusCode.NotAcceptable:
        break;
    case System.Net.HttpStatusCode.ProxyAuthenticationRequired:
        break;
    case System.Net.HttpStatusCode.RequestTimeout:
        break;
    case System.Net.HttpStatusCode.Conflict:
        break;
    case System.Net.HttpStatusCode.Gone:
        break;
    case System.Net.HttpStatusCode.LengthRequired:
        break;
    case System.Net.HttpStatusCode.PreconditionFailed:
        break;
    case System.Net.HttpStatusCode.RequestEntityTooLarge:
        break;
    case System.Net.HttpStatusCode.RequestUriTooLong:
        break;
    case System.Net.HttpStatusCode.UnsupportedMediaType:
        break;
    case System.Net.HttpStatusCode.RequestedRangeNotSatisfiable:
        break;
    case System.Net.HttpStatusCode.ExpectationFailed:
        break;
    case System.Net.HttpStatusCode.MisdirectedRequest:
        break;
    case System.Net.HttpStatusCode.UnprocessableEntity:
        break;
    case System.Net.HttpStatusCode.Locked:
        break;
    case System.Net.HttpStatusCode.FailedDependency:
        break;
    case System.Net.HttpStatusCode.UpgradeRequired:
        break;
    case System.Net.HttpStatusCode.PreconditionRequired:
        break;
    case System.Net.HttpStatusCode.TooManyRequests:
        break;
    case System.Net.HttpStatusCode.RequestHeaderFieldsTooLarge:
        break;
    case System.Net.HttpStatusCode.UnavailableForLegalReasons:
        break;
    case System.Net.HttpStatusCode.InternalServerError:
        break;
    case System.Net.HttpStatusCode.NotImplemented:
        break;
    case System.Net.HttpStatusCode.BadGateway:
        break;
    case System.Net.HttpStatusCode.ServiceUnavailable:
        break;
    case System.Net.HttpStatusCode.GatewayTimeout:
        break;
    case System.Net.HttpStatusCode.HttpVersionNotSupported:
        break;
    case System.Net.HttpStatusCode.VariantAlsoNegotiates:
        break;
    case System.Net.HttpStatusCode.InsufficientStorage:
        break;
    case System.Net.HttpStatusCode.LoopDetected:
        break;
    case System.Net.HttpStatusCode.NotExtended:
        break;
    case System.Net.HttpStatusCode.NetworkAuthenticationRequired:
        break;
    default:
        break;
}

//Example 5: Using GetFromJsonAsync
var deserializeResp = await httpClient.GetFromJsonAsync<List<WeatherForecast>>(url);

//Example 6: Using PostAsJsonAsync
var wf = new WeatherForecast()
{
    Date = DateOnly.FromDateTime(DateTime.Now),
    Summary = "HOT",
    TemperatureC = 30,
}; 

var response2 = await httpClient.PostAsJsonAsync(url,wf);
if (response2.IsSuccessStatusCode)
{
    var body2 = await response2.Content.ReadAsStringAsync();
    //Console.WriteLine(body2);
}

//Example 7: Using PostAsync
var serializedObj = JsonSerializer.Serialize(wf);
var stringContent = new StringContent(serializedObj, Encoding.UTF8,"application/json");
var response3 = await httpClient.PostAsync(url, stringContent);
if (response3.IsSuccessStatusCode)
{
    var body3 = await response3.Content.ReadAsStringAsync();
    //Console.WriteLine(body3);
}
else
{
    var json = await response3.Content.ReadAsStringAsync();
    var fieldWithErrors = Utils.ExtractErrorsFromWebAPI(json);
    foreach (var err in fieldWithErrors)
    {
        Console.WriteLine($"- {err.Key}");
        foreach (var item in err.Value)
        {
            Console.WriteLine(item);
        }
    }

}


//Example 8: request without sending a value through the header
//Console.WriteLine(await httpClient.GetStringAsync($"{url}/uppercase"));

//Example 9: request  sending a value through the header
using(var httpRequest = new HttpRequestMessage(HttpMethod.Get, $"{url}/uppercase"))
{
    httpRequest.Headers.Add("customValue", "I am Uli");
    var response4 = await httpClient.SendAsync(httpRequest); 
    //Console.WriteLine(await response4.Content.ReadAsStringAsync());
}


//Example 10: always sending a value through the header
httpClient.DefaultRequestHeaders.Add("customValue", "I am Uli");
//Console.WriteLine(await httpClient.GetStringAsync($"{url}/uppercase"));


//Example 11: Factory
var serviceCollection = new ServiceCollection();
Configure(serviceCollection);
var services = serviceCollection.BuildServiceProvider();    
var httpClientFactory = services.GetRequiredService<IHttpClientFactory>();

var httpClient2 = httpClientFactory.CreateClient();
var response5 = await httpClient2.GetAsync($"{url}/uppercase");
///Console.WriteLine(await response5.Content.ReadAsStringAsync());


//Example 12: Named Client
//var weatherForecastClient = httpClientFactory.CreateClient("weather");
//Console.WriteLine( await weatherForecastClient.GetStringAsync("uppercase"));

//Example 13: Typed Client
var weatherForecastClient = services.GetRequiredService<IWeatherForecastClient>();
var list = await weatherForecastClient.GetAll();
Console.WriteLine("Done");




static void Configure(ServiceCollection services)
{
    // Example 1 : Basic usage
    services.AddHttpClient();

    services.AddHttpClient("weather", opts =>
    {
        opts.BaseAddress = new Uri("http://localhost:5022/WeatherForecast/");
        opts.DefaultRequestHeaders.Add("customValue", "I am named client");

    });
    // Example 2 : Named Clients
    services.AddHttpClient("tasks", opts =>
    {
        opts.BaseAddress = new Uri("http://localhost:5022/WeatherForecast/todos/");
    });

    //Example: 3 Type CLient
    services.AddHttpClient<IWeatherForecastClient, WeatherForecastClient>();
}
