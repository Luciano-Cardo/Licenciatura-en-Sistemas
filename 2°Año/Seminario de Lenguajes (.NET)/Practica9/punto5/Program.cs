// 5)  En esta teoría vimos que la clase List<T> implementa el método Foreach que recibe un Action<T> como parámetro y que permite 
//     código como el siguiente:
//     List<int> lista = [1, 2, 3];
//     lista.ForEach(i => Console.Write(i + ","));

//     Salida por consola
//     1,2,3

//     Sin embargo, Foreach no está definido para los arreglos. Se desea implementar un método de extensión para todas las clases que
//     implementen la interfaz IEnumerable<T>, para hacer posible el siguiente código:
//     int[] vector = [1, 2, 3];
//     vector.ForEach(i => Console.Write(i + ","));
//     "Hola Mundo".ForEach(c => Console.Write(c + ","));

//     Salido por consola
//     1,2,3,H,o,l,a, ,M,u,n,d,o,

//     Para ello completar la siguiente clase estática:
//     public static class Extensiones
//     {
//         public static void ForEach<T>(this IEnumerable<T> secuencia, . . .
//         . . .

public static class Extensiones
{
    public static void ForEach<T>(this IEnumerable<T> secuencia, Action<T> accion)
    {
        foreach (T elemento in secuencia)
        {
            accion(elemento);
        }
    }
}

class Program
{
    static void Main()
    {
        int[] vector = { 1, 2, 3 };
        vector.ForEach(i => Console.Write(i + ","));
        "Hola Mundo".ForEach(c => Console.Write(c + ","));
    }
}
