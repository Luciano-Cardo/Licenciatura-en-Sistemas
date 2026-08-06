// 1) Definir una clase Persona con 3 campos públicos: Nombre, Edad y DNI. Escribir un algoritmo que permita al usuario ingresar en 
//    una consola una serie de datos de esta forma: Nombre,Documento,Edad <ENTER>.
//    Una vez finalizada la entrada de datos, el programa debe imprimir en la consola un listado con 4
//    columnas de la siguiente forma:
//    Nro) Nombre Edad DNI.
//    Ejemplo de listado por consola:
//    1) Juan Perez 40 2098745
//    2) José García 41 1965412
//    NOTA: Se puede utilizar: Console.SetIn(new System.IO.StreamReader(nombreDeArchivo)); para cambiar la entrada estándar de la 
//    consola y poder leer directamente desde un archivo de texto.

namespace punto1
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
                Persona p = new Persona();
                p.Nombre = partes[0];
                p.Dni = int.Parse(partes[1]);
                p.Edad = int.Parse(partes[2]);
                personas.Add(p);
            }
            Console.WriteLine("\nListado:");
            for (int i = 0; i < personas.Count; i++)
            {
                Persona p = personas[i];
                Console.WriteLine($"{i + 1}) {p.Nombre} {p.Edad} {p.Dni}");
            }
        }
    }
}