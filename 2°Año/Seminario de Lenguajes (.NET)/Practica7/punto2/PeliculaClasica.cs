namespace punto2;

public class PeliculaClasica : IAlquilable, IVendible
{
    public void SeAlquilaA(Persona p)
    {
        Console.WriteLine("Alquilando pelicula clasica a persona");
    }
    public void SeDevuelvePor(Persona p)
    {
        Console.WriteLine("Pelicula clasica devuelta por persona");
    }
    public void SeVende(Persona p)
    {
        Console.WriteLine("Vendiendo película clásica a persona");
    }
}
