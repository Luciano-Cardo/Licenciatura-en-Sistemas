using Microsoft.Extensions.Options;

namespace Aplicacion;

public class ProcesadorArchivos : IProcesador
{
    private readonly ProcesadorOptions _options;

    public ProcesadorArchivos(IOptions<ProcesadorOptions> options)
    {
        _options = options.Value;
    }

    public void Procesar()
    {
        Console.WriteLine($"Procesando un máximo de {_options.MaxArchivosPorLote} archivos desde la ruta: {_options.DirectorioEntrada}");
    }
}