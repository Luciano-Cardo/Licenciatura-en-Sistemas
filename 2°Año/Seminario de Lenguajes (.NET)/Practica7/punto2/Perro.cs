namespace punto2;

public class Perro : IVendible, IAtendible, ILavable
{
    public void SeVende(Persona p)
    {
        Console.WriteLine("Vendiendo perro a persona");
    }
    public void Atender()
    {
        Console.WriteLine("Atendiendo perro");
    }
    public void Lavar()
    {
        Console.WriteLine("Lavando perro");
    }
    public void Secar()
    {
        Console.WriteLine("Secando perro");
    }
}

