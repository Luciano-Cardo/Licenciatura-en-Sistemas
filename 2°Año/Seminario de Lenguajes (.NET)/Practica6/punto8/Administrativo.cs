namespace punto8;

public class Administrativo : Empleado
{
    public double Premio {get; set;}

    public Administrativo (string nombre, int dni, DateTime fecha, double salarioBase): base(nombre, dni, fecha, salarioBase)
    {
    }

    public override double Salario
    {
        get {return SalarioBase + Premio;}
    }
    public override void AumentarSalario()
    {
        SalarioBase += SalarioBase * Antiguedad() / 100;
    }
}
