namespace projeto_ruim.Routes;

public interface IHttpRoute
{
    public HttpVerb Verb { get; init; }
    public string TemplateRoute { get; init; }
    public Delegate Handler { get; init; }
}

public enum HttpVerb
{
    GET,
    POST,
    PUT,
    DELETE
}