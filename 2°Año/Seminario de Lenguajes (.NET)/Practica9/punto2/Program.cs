// 2)  Codificar los métodos que faltan para que el siguiente código produzca la salida en la consola indicada.

//     int[] vector1 = [1, 2, 3];
//     bool[] vector2 = [true, true, true];
//     string[] vector3 = ["uno", "dos", "tres"];
//     Set<int>(vector1, 110, 2);
//     Set<bool>(vector2, false, 1);
//     Set<string>(vector3, "Hola Mundo!", 0);
//     Imprimir(vector1);
//     Imprimir(vector2);
//     Imprimir(vector3);

//     Salida por consola
//     1 2 110
//     True False True
//     Hola Mundo! dos tres

//     Debe evitarse que durante la ejecución del método Imprimir se produzca boxing o unboxing. Tip El método Imprimir también 
//     es un método genérico, no se advierte fácilmente porque no se ha explicitado el parámetro de tipo (el compilador lo infiere)

class Program
{
    public static void Set<T>(T[] vector, T valor, int indice)
    {
        vector[indice] = valor;
    }

    public static void Imprimir<T>(T[] vector)
    {
        foreach (T elemento in vector)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] vector1 = { 1, 2, 3 };
        bool[] vector2 = { true, true, true };
        string[] vector3 = { "uno", "dos", "tres" };
        Set<int>(vector1, 110, 2);
        Set<bool>(vector2, false, 1);
        Set<string>(vector3, "Hola Mundo!", 0);
        Imprimir(vector1);
        Imprimir(vector2);
        Imprimir(vector3);
    }
}