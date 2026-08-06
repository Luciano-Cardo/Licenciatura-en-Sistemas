// 4) Implementar los métodos GetDiagonalPrincipal y GetDiagonalSecundaria que devuelven
//    un vector con la diagonal correspondiente de la matriz pasada como parámetro. Si la matriz no es
//    cuadrada generar una excepción ArgumentException.

double [,] m =
{
    {1.1, 2.2, 3.3},
    {4.4, 5.5, 6.6},
    {6.6, 7.7, 8.8}
};

double[] GetDiagonalPrincipal(double[,] matriz)
{
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);

    if(filas != columnas)
    {
        throw new ArgumentException("La matriz no es cuadrada");
    }

    double [] diagonal = new double [filas];

    for (int i = 0; i < filas; i++)
    {
        diagonal[i] = matriz[i,i];
        Console.Write(diagonal[i]+" ");
    }

    return diagonal;
}

double[] GetDiagonalSecundaria(double[,] matriz)
{
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);

    if(filas != columnas)
    {
        throw new ArgumentException("La matriz no es cuadrada");
    }

    double [] diagonal = new double [filas];

    for (int i = 0; i < filas; i++)
    {
        diagonal[i] = matriz[i,columnas-1-i];
        Console.Write(diagonal[i]+" ");
    }

    return diagonal;
}

GetDiagonalPrincipal(m);
Console.WriteLine();
GetDiagonalSecundaria(m);