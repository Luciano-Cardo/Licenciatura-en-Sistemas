namespace punto10;

public class Cuenta
{
    private double _monto;
    private int? _titularDNI;
    private string? _titularNombre;

    public Cuenta()
    {
        _monto = 0;
        _titularDNI = null;
        _titularNombre = null;
    }

    public Cuenta(int dni) : this()
    {
        _titularDNI = dni;
    }

    public Cuenta(string nombre) : this()
    {
        _titularNombre = nombre;
    }

    public Cuenta(string nombre, int dni) : this()
    {
        _titularNombre = nombre;
        _titularDNI = dni;
    }

    public void Depositar(double monto)
    {
        _monto += monto;
    }

    public void Extraer(double monto)
    {
        if (monto <= _monto)
        {
            _monto -= monto;
        }
        else
        {
            Console.WriteLine("Operación cancelada, monto insuficiente");
        }
    }

    public void Imprimir()
    {
        string nombre = _titularNombre ?? "No especificado";
        string dni = _titularDNI?.ToString() ?? "No especificado";

        Console.WriteLine($"Nombre: {nombre}, DNI: {dni}, Monto: {_monto}");
    }
}
