// 6) Implementar los siguientes métodos que devuelvan la suma, resta y multiplicación de matrices pasadas como parámetros. 
//    Para el caso de la suma y la resta, las matrices deben ser del mismo tamaño, en caso de no serlo devolver null. Para el caso de 
//    la multiplicación la cantidad de columnas de A debe ser igual a la cantidad de filas de B, en caso contrario generar una excepción
//    ArgumentException.

double[,] A = {
    {1, 2},
    {3, 4}
};

double[,] B = {
    {5, 6},
    {7, 8}
};

double[,]? Suma(double[,] A, double[,] B)
{
    int filasA = A.GetLength(0);
    int filasB = B.GetLength(0);
    int columnasA = A.GetLength(1);
    int columnasB = B.GetLength(1);

    if ((filasA != filasB) || (columnasA != columnasB))
        return null;

    double [,] resultado = new double [filasA,columnasA];

    for (int i = 0; i < filasA; i++)
    {
        for (int j = 0; j < columnasA; j++)
        {
            resultado[i,j] = A[i,j] + B[i,j];
        }
    }

    return resultado;
}
double[,]? Resta(double[,] A, double[,] B)
{
    int filasA = A.GetLength(0);
    int filasB = B.GetLength(0);
    int columnasA = A.GetLength(1);
    int columnasB = B.GetLength(1);

    if ((filasA != filasB) || (columnasA != columnasB))
        return null;

    double [,] resultado = new double [filasA,columnasA];

    for (int i = 0; i < filasA; i++)
    {
        for (int j = 0; j < columnasA; j++)
        {
            resultado[i,j] = A[i,j] - B[i,j];
        }
    }

    return resultado;
}
double[,] Multiplicacion(double[,] A, double[,] B)
{
    int filasA = A.GetLength(0);
    int columnasA = A.GetLength(1);

    int filasB = B.GetLength(0);
    int columnasB = B.GetLength(1);

    if (columnasA != filasB)
        throw new ArgumentException("No se pueden multiplicar las matrices");

    double[,] resultado = new double[filasA, columnasB];

    for (int i = 0; i < filasA; i++)
    {
        for (int j = 0; j < columnasB; j++)
        {
            for (int k = 0; k < columnasA; k++)
            {
                resultado[i, j] += A[i, k] * B[k, j];
            }
        }
    }

    return resultado;
}

Suma(A,B);
Resta(A,B);
Multiplicacion(A,B);