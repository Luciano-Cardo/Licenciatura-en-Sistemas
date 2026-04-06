// 12) Realizar un análisis sintáctico para determinar si los paréntesis en una expresión aritmética están bien balanceados. 
//     Verificar que por cada paréntesis de apertura exista uno de cierre en la cadena de entrada. Utilizar una pila para resolverlo.
//     Los paréntesis de apertura de la entrada se almacenan en una pila hasta encontrar uno de cierre, realizándose entonces la 
//     extracción del último paréntesis de apertura almacenado. Si durante el proceso se lee un paréntesis de cierre y la pila está 
//     vacía, entonces la cadena es incorrecta. Al finalizar el análisis, la pila debe quedar vacía para que la cadena leída sea 
//     aceptada, de lo contrario la misma no es válida.

bool ParentesisBalanceados(string expresion)
{
    Stack<char> pila = new Stack<char>();

    foreach (char c in expresion)
    {
        if (c == '(')
        {
            pila.Push(c);
        }
        else if (c == ')')
        {
            if (pila.Count == 0)
                return false;

            pila.Pop();
        }
    }

    return pila.Count == 0;
}

Console.WriteLine(ParentesisBalanceados("(1+2)*(3+4)"));
Console.WriteLine(ParentesisBalanceados("(1+2*(3+4)"));  
Console.WriteLine(ParentesisBalanceados(")(1+2)"));      