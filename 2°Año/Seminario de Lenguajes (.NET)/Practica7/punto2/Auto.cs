namespace punto2;

public class Auto : IVendible, ILavable, IReciclable
{
    public void SeVende(Persona p)
    {
        Console.WriteLine("Vendiendo auto a persona");
    }
    public void Lavar()
    {
        Console.WriteLine("Lavando auto");
    }
    public void Secar()
    {
        Console.WriteLine("Secando auto");
    }
    public void Reciclar()
    {
        Console.WriteLine("Reciclando auto");
    }
}
