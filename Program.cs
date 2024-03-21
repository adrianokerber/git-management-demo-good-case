using projeto_ruim.Routes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApiDocument(x => x.Title = "Projeto Bom");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi(); // serve OpenAPI/Swagger documents
    app.UseSwaggerUi(); // serve Swagger UI
    //app.UseReDoc(); // serve ReDoc UI
}

app.UseHttpsRedirection();

// Register Endpoints:
app.RegisterEndpointGetWeatherForecast()
   .RegisterEndpointGetCurrentTemperature();

app.Run();
