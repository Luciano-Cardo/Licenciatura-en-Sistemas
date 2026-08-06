// 3) Agregar a la clase Persona un método EsMayorQue(Persona p) que devuelva verdadero si la persona que recibe el mensaje tiene 
//    más edad que la persona enviada como parámetro. Utilizarlo para realizar un programa que devuelva la persona más jóven de la 
//    lista.

namespace punto3
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
                Persona p = new Persona(nombre,edad,dni);
                personas.Add(p);
            }
            Console.WriteLine("\nListado:");
            for (int i = 0; i < personas.Count; i++)
            {
                Persona p = personas[i];
                Console.WriteLine($"{i + 1}) {p.Imprimir()}");
            }
            Persona menor = personas[0];

            for (int i = 1; i < personas.Count; i++)
            {
                if (menor.EsMayorQue(personas[i]))
                {
                    menor = personas[i];
                }
            }
            Console.WriteLine("\nLa persona más joven es:");
            Console.WriteLine(menor.Imprimir());
        }
    }
}