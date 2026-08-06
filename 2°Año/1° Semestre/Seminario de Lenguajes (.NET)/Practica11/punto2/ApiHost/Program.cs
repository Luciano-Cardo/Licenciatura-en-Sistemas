// 2)  1. Crear una solución con dos proyectos: Aplicación y ApiHost. En el proyecto Aplicacion, crear un servicio llamado ServicioNotificacion 
//        y registrarlo en la API como Scoped (simulando que necesita datos específicos de la petición actual del usuario).
//     2. Crear un servicio llamado GestorAlertasGlobales y registralo como Singleton (simulando un proceso central que vive siempre).
//     3. Inyectar el ServicioNotificacion dentro del constructor de GestorAlertasGlobales.
//     4. Intentar inyectar GestorAlertasGlobales en cualquier endpoint de prueba y ejecutar la aplicación.

using Aplicacion;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ServicioNotificacion>();

builder.Services.AddSingleton<GestorAlertasGlobales>();

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.MapGet("/prueba", (GestorAlertasGlobales gestor) =>
{
    gestor.GenerarAlerta();
    return Results.Ok("Alerta enviada");
});

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
