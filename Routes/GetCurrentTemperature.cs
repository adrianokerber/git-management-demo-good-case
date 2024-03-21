using Microsoft.AspNetCore.Mvc;

namespace projeto_ruim.Routes;

public static class GetCurrentTemperature
{
    public static WebApplication RegisterEndpointGetCurrentTemperature(this WebApplication app)
    {
        app.MapGet("/current-temperature/{where}", ([FromRoute] string where) =>
                new {
                    when = DateTimeOffset.UtcNow,
                    city = where,
                    temperatureC = "38.5 C°"
                }
            ).WithName("GetCurrentTemperature")
            .WithOpenApi();

        return app;
    }
}