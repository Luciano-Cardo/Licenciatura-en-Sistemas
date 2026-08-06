// 2) Implementar un método para imprimir por consola todos los elementos de una matriz (arreglo de dos
// dimensiones) pasada como parámetro. Debe imprimir todos los elementos de una fila en la misma línea
// en la consola.
// Ayuda: Si A es un arreglo, A.GetLength(i) devuelve la longitud del arreglo en la dimensión i.

double[,] m ={ 
    {1.1, 2.2, 5.5}, 
    {3.3, 4.4, 6.6}
};

void ImprimirMatriz(double[,] matriz){
    for (int i = 0; i < matriz.GetLength(0); i++){
        for (int j = 0; j < matriz.GetLength(1); j++){
            Console.Write(matriz[i,j]+" ");
        }
        Console.WriteLine();
    }
}

ImprimirMatriz(m);