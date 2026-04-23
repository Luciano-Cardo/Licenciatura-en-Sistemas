namespace punto8;

public class Vendedor : Empleado
{
    public double Comision {get; set;}

    public Vendedor (string nombre, int dni, DateTime fecha, double salarioBase): base(nombre, dni, fecha, salarioBase)
    {
    }
    public override double Salario
    {
        get {return SalarioBase + Comision;}
    }

    public override void AumentarSalario()
    {
        if (Antiguedad() < 10)
        {
            SalarioBase += SalarioBase * 5 /100;
        }else SalarioBase +=  SalarioBase * 10 /100;
    }
}
