namespace Aplicacion;

public class GestorAlertasGlobales
{
    private readonly ServicioNotificacion _servicioNotificacion;

    public GestorAlertasGlobales(ServicioNotificacion servicioNotificacion)
    {
        _servicioNotificacion = servicioNotificacion;
    }

    public void GenerarAlerta()
    {
        _servicioNotificacion.Enviar("Alerta global");
    }
}