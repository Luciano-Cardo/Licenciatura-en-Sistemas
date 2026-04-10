namespace punto2;

public class Persona
{
    private String _nombre;
    private int _edad;
    private int _dni;

    public Persona(String nombre,int edad, int dni)
    {
        _nombre = nombre;
        _edad = edad;
        _dni = dni;
    }

    public String Imprimir()
    {
        return $"{_nombre} {_edad} {_dni}";
    }
}