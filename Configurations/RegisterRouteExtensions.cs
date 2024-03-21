using projeto_ruim.Routes;

namespace projeto_ruim.Configurations;

public static class RegisterRouteExtensions
{
    public static WebApplication RegisterRoute(this WebApplication app, IHttpRoute httpRoute)
    {
        
        RegisterOnWebApplication(app, httpRoute.Verb, httpRoute.TemplateRoute, httpRoute.Handler);
        return app;
    }
    
    private static void RegisterOnWebApplication(WebApplication app, HttpVerb verb, string route, Delegate handler)
    {
        if (route == null || handler == null)
            throw new NullReferenceException("IHttpRoute => One or more properties undefined!");
        
        switch (verb)
        {
            case HttpVerb.GET:
                app.MapGet(route, handler);
                return;
            case HttpVerb.POST:
                app.MapPost(route, handler);
                return;
            case HttpVerb.PUT:
                app.MapPut(route, handler);
                return;
            default:
                throw new NotImplementedException($"Method {verb} not implemented!");
        }
    }
}