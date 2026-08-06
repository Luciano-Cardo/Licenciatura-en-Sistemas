namespace punto8;

public abstract class Empleado
{
    public string Nombre {get;}
    public int Dni {get;}
    public DateTime FechaDeIngreso {get;}
    public double SalarioBase {get; protected set;}
    public abstract double Salario {get;}

    public Empleado(string nombre, int dni, DateTime fecha, double salarioBase)
    {
        Nombre = nombre;
        Dni = dni;
        FechaDeIngreso = fecha;
        SalarioBase = salarioBase;
    }
    public int Antiguedad()
    {
        DateTime hoy = DateTime.Now;
        int años = hoy.Year - FechaDeIngreso.Year;

        if (FechaDeIngreso > hoy.AddYears(-años))
            años--;

        return años;
    }
    public abstract void AumentarSalario();

    public override string ToString()
    {
        return $"{GetType().Name} Nombre: {Nombre}, DNI: {Dni} Antigüedad: {Antiguedad()}\n" +
               $"Salario base: {SalarioBase}, Salario: {Salario}\n-------------";
    }
}
