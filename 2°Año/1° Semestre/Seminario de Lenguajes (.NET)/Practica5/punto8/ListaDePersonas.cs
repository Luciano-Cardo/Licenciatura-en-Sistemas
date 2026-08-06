namespace punto8;

public class ListaDePersonas
{
    private List<Persona> personas = new List<Persona>();

    public void Agregar(Persona p)
    {
        personas.Add(p);
    }

    public Persona this[int dni]
    {
        get
        {
            foreach (var p in personas)
            {
                if (p._dni == dni)
                    return p;
            }
            return null;
        }
    }

    public List<string> this[char inicial]
    {
        get
        {
            List<string> resultado = new List<string>();

            foreach (var p in personas)
            {
                if (!string.IsNullOrEmpty(p._nombre) && p._nombre[0] == inicial)
                {
                    resultado.Add(p._nombre);
                }
            }

            return resultado;
        }
    }
}
