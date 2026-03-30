// 15) Escribir un programa que reciba una lista de nombres como parámetro por la línea de comandos e imprima por consola un saludo
//     personalizado para cada uno de ellos.
//         a) Utilizando la sentencia for
//         b) Utilizando la sentencia foreach

using System;

class Program
{
    static void Main(String[] args)
    {
        //Usando For
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine("Hola "+ args[i]);
        }

        Console.WriteLine("===================");

        //Usando Foreach
        foreach (String st in args)
        {
            Console.WriteLine("Hola " +st);
        }
    }
}
