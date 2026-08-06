// 2) Modificar el programa anterior haciendo privados todos los campos. Definir un constructor adecuado y un método público 
//    Imprimir() que escriba en la consola los campos del objeto con el formato requerido para el listado.

namespace punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            Console.WriteLine("Ingrese datos: Nombre,DNI,Edad (ENTER vacío para terminar)");
            while (true)
            {
                string? linea = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(linea))
                    break;
                string[] partes = linea.Split(',');
                String nombre = partes[0];
                int dni = int.Parse(partes[1]);
                int edad = int.Parse(partes[2]);
                Persona p = new Persona(nombre,dni,edad);
                personas.Add(p);
            }
            Console.WriteLine("\nListado:");
            for (int i = 0; i < personas.Count; i++)
            {
                Persona p = personas[i];
                Console.WriteLine($"{i + 1}) {p.Imprimir()}");
            }
        }
    }
}