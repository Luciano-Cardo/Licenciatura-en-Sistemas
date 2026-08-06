// 13) Utilizar la clase Stack<T> (pila) para implementar un programa que pase un número en base 10 a otra base realizando divisiones 
//     sucesivas. Por ejemplo para pasar 35 en base 10 a binario dividimos sucesivamente por dos hasta encontrar un cociente menor 
//     que el divisor, luego el resultado se obtiene leyendo de abajo hacia arriba el cociente de la última división seguida por 
//     todos los restos.

string ConvertirABase(int numero, int baseDestino)
{
    if (numero == 0)
    {
        return "0";
    }

    Stack<int> pila = new Stack<int>();

    while (numero > 0)
    {
        int resto = numero % baseDestino;
        pila.Push(resto);
        numero = numero / baseDestino;
    }

    string resultado = "";

    while (pila.Count > 0)
    {
        int digito = pila.Pop();

        if (digito >= 10)
            resultado += (char)('A' + digito - 10);
        else
            resultado += digito.ToString();
    }

    return resultado;
}

Console.WriteLine(ConvertirABase(35, 2));