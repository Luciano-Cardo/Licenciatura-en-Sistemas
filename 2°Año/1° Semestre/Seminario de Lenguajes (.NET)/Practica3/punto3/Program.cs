// 3) Implementar el método ImprimirMatrizConFormato, similar al anterior pero ahora con un
//    parámetro más que representa la plantilla de formato que debe aplicarse a los números al imprimirse.
//    La plantilla de formato es un string de acuerdo a las convenciones de formato compuesto, por ejemplo
//    “0.0” implica escribir los valores reales con un dígito para la parte decimal.

double[,] m =
{
    {1.12, 2.27},
    {3.36, 4.41}
};

void ImprimirMatrizConFormato(double[,] matriz, string formatString)
{
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write(matriz[i,j].ToString(formatString)+" ");
        }
        Console.WriteLine();
    }
}

ImprimirMatrizConFormato(m, "0.0");