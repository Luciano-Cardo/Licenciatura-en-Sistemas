// 4)  Dada la siguiente clase genérica

//     class Nodo<T>
//     {
//         public T Valor { get; private set; }
//         public Nodo<T>? Proximo { get; set; } = null;
//         public Nodo(T valor) => Valor = valor;
//     }

//     Utilizar la clase Nodo<T> para codificar codificar una lista enlazada genérica tal manera que el código siguiente produzca la 
//     salida indicada:
//     var lista = new ListaEnlazada<int>();
//     lista.AgregarAdelante(3);
//     lista.AgregarAdelante(100);
//     lista.AgregarAtras(10);
//     lista.AgregarAtras(11);
//     lista.AgregarAdelante(0);
//     IEnumerator<int> enumerador = lista.GetEnumerator();
//     while (enumerador.MoveNext())
//     {
//         int i = enumerador.Current;
//         Console.Write(i + " ");
//     }
//     Console.WriteLine();

//     Salida por consola
//     0 100 3 10 11

using System.Collections;
using System.Collections.Generic;

class Nodo<T>
{
    public T Valor { get; private set; }
    public Nodo<T>? Proximo { get; set; } = null;
    public Nodo(T valor)
    {
        Valor = valor;
    }
}

class ListaEnlazada<T> : IEnumerable<T>
{
    private Nodo<T>? inicio = null;
    public void AgregarAdelante(T valor)
    {
        Nodo<T> nuevo = new Nodo<T>(valor);
        nuevo.Proximo = inicio;
        inicio = nuevo;
    }
    public void AgregarAtras(T valor)
    {
        Nodo<T> nuevo = new Nodo<T>(valor);
        if (inicio == null)
        {
            inicio = nuevo;
            return;
        }
        Nodo<T> aux = inicio;
        while (aux.Proximo != null)
        {
            aux = aux.Proximo;
        }
        aux.Proximo = nuevo;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Nodo<T>? aux = inicio;
        while (aux != null)
        {
            yield return aux.Valor;
            aux = aux.Proximo;
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class Program
{
    static void Main()
    {
        var lista = new ListaEnlazada<int>();
        lista.AgregarAdelante(3);
        lista.AgregarAdelante(100);
        lista.AgregarAtras(10);
        lista.AgregarAtras(11);
        lista.AgregarAdelante(0);
        IEnumerator<int> enumerador = lista.GetEnumerator();
        while (enumerador.MoveNext())
        {
            int i = enumerador.Current;
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
