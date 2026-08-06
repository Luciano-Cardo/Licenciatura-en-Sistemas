namespace punto4;

public class NumeroIngresadoEventArgs : EventArgs
{
    public int Valor { get; set; }

    public NumeroIngresadoEventArgs(int valor)
    {
        Valor = valor;
    }
}
