namespace punto12;

public class Libro
{
    public string ISBN { get; }

    public DateTime? FechaPublicacion { get; init; }

    public string Titulo { get; init; }

    public double Precio { get; set; }

    public Libro(string isbn)
    {
        ISBN = isbn;
    }

}
