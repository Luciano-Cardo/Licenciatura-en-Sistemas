// 1)  1. Crear una solución con dos proyectos: Aplicación y ConsolaHost. En el proyecto Aplicacion, crear una clase ProcesadorArchivos que 
//        implemente una interfaz IProcesador. Esta clase debe simular el  procesamiento de archivos en un directorio.
//     2. Su comportamiento debe ser configurable. Crear una clase llamada ProcesadorOptions con dos propiedades: DirectorioEntrada (string) 
//        y MaxArchivosPorLote (int). Inyectar esta clase de opciones en el constructor de ProcesadorArchivos.
//     3. En el método Procesar() de este servicio, imprimir en consola un mensaje que diga: "Procesando un máximo de {MaxArchivosPorLote} 
//        archivos desde la ruta: {DirectorioEntrada}".
//     4. En el proyecto ConsolaHost, agregar las configuraciones correspondientes en el archivo appsettings.json. y crear la clase 
//        AppRunner (similar a como se hizo en esta teoría)
//     5. Modificar el Program.cs para registrar estas opciones, registrar el servicio IProcesador, e inyectarlo en la clase AppRunner.
//     6. Ejecutar la aplicación y verificar que el mensaje muestre los valores leídos del JSON.

using Aplicacion;
using ConsolaHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

builder.Services.Configure<ProcesadorOptions>(
    builder.Configuration.GetSection("ProcesadorOptions"));

builder.Services.AddTransient<IProcesador, ProcesadorArchivos>();

builder.Services.AddTransient<AppRunner>();

using IHost host = builder.Build();

var app = host.Services.GetRequiredService<AppRunner>();

app.Run();
