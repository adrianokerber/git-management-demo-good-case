namespace projeto_ruim.Routes;

public class GetWeatherForecast : IHttpRoute
{
    // public WebApplication RegisterEndpointGetWeatherForecast(WebApplication app)
    // {
    //     var summaries = new[]
    //     {
    //         "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    //     };
    //     
    //     app.MapGet("/weatherforecast", () =>
    //         {
    //             var forecast =  Enumerable.Range(1, 5).Select(index =>
    //                     new WeatherForecast
    //                     (
    //                         DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
    //                         Random.Shared.Next(-20, 55),
    //                         summaries[Random.Shared.Next(summaries.Length)]
    //                     ))
    //                 .ToArray();
    //             return forecast;
    //         })
    //         .WithName("GetWeatherForecast")
    //         .WithOpenApi();
    //
    //     return app;
    // }
    
    private static readonly string[] _summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public HttpVerb Verb { get; init; } = HttpVerb.GET;
    public string TemplateRoute { get; init; } = "/weatherforecast";

    public Delegate Handler { get; init; } = () =>
    {
        var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    _summaries[Random.Shared.Next(_summaries.Length)]
                ))
            .ToArray();
        return forecast;
    };
    
    record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
    {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}