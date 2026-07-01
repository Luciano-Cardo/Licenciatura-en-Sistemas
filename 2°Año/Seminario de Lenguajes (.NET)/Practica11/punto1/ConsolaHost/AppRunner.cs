using Aplicacion;

namespace ConsolaHost;

public class AppRunner
{
    private readonly IProcesador _procesador;

    public AppRunner(IProcesador procesador)
    {
        _procesador = procesador;
    }

    public void Run()
    {
        _procesador.Procesar();
    }
}