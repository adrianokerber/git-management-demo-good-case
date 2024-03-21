using Microsoft.AspNetCore.Mvc;

namespace projeto_ruim.Routes;

public class GetCurrentTemperature : IHttpRoute
{
    public HttpVerb Verb { get; init; } = HttpVerb.GET;

    public string TemplateRoute { get; init; } = "/current-temperature";

    public Delegate Handler { get; init; } = (string where) =>
        new
        {
            when = DateTimeOffset.UtcNow,
            where,
            temperatureC = "38.5 C°"
        };
}