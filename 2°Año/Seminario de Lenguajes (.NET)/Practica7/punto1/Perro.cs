namespace punto1;

public class Perro : IVendible, IAtendible
{
    public void SeVende(Persona p)
    {
        Console.WriteLine("Vendiendo perro a persona");
    }
    public void Atender()
    {
        Console.WriteLine("Atendiendo perro");
    }
}
