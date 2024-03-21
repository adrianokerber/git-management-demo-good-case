using Microsoft.AspNetCore.Mvc;

namespace projeto_ruim.Routes;

public static class GetCurrentTemperature
{
    public static WebApplication RegisterEndpointGetCurrentTemperature(this WebApplication app)
    {
        app.MapGet("/current-degrees/{where}", ([FromRoute] string where, DateTimeOffset when) =>
                new {
                    when,
                    city = where,
                    temperatureC = "38.5 C°"
                }
            ).WithName("GetCurrentTemperature")
            .WithOpenApi();

        return app;
    }
}