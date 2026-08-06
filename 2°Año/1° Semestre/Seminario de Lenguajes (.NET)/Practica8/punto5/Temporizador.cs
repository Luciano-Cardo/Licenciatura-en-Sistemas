namespace punto5;

public class Temporizador
{
    private int _intervalo;
    private bool _habilitado;
    private int _contador = 0;

    public event EventHandler<TicEventArgs>? Tic;

    public int Intervalo
    {
        get => _intervalo;

        set
        {
            if (value >= 100)
                _intervalo = value;
        }
    }

    public bool Habilitado
    {
        get => _habilitado;

        set
        {
            if (value == true && Tic == null)
                return;

            _habilitado = value;

            if (_habilitado)
                Ejecutar();
        }
    }
    private async void Ejecutar()
    {
        while (_habilitado)
        {
            await Task.Delay(_intervalo);

            _contador++;

            Tic?.Invoke(this,
                new TicEventArgs(_contador));
        }
    }
}
