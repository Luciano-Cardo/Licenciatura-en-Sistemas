namespace punto2;

public class Pelicula: IAlquilable
{
    public void SeAlquilaA(Persona p)
    {
        Console.WriteLine("Alquilando pelicula a persona");
    }
    public void SeDevuelvePor(Persona p)
    {
        Console.WriteLine("Pelicula devuelta por persona");
    }
}
