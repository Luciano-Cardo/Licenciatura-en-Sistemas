// 5) Implementar un método que devuelva un arreglo de arreglos con los mismos elementos que la matriz pasada como parámetro:

double[,] m = {
    {1, 2},
    {3, 4}
};

double[][] GetArregloDeArreglo(double[,] matriz)
{
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);

    double[][] resultado = new double[filas][];

    for (int i = 0; i < filas; i++)
    {
        resultado[i] = new double[columnas];

        for (int j = 0; j < columnas; j++)
        {
            resultado[i][j] = matriz[i, j];
        }
    }

    return resultado;
}

GetArregloDeArreglo(m);
