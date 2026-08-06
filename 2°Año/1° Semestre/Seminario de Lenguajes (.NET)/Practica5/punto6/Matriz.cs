namespace punto6;

public class Matriz
{
    private double[,] datos;
    private int filas;
    private int columnas;

    public Matriz(int filas, int columnas)
    {
        this.filas = filas;
        this.columnas = columnas;
        datos = new double[filas, columnas];
    }

    public Matriz(double[,] matriz)
    {
        filas = matriz.GetLength(0);
        columnas = matriz.GetLength(1);
        datos = matriz;
    }

    public double this[int fila, int columna]
    {
        get { return datos[fila, columna]; }
        set { datos[fila, columna] = value; }
    }

    public void imprimir()
    {
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(datos[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public void imprimir(string formatString)
    {
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(datos[i, j].ToString(formatString) + "\t");
            }
            Console.WriteLine();
        }
    }

    public double[] GetFila(int fila)
    {
        double[] resultado = new double[columnas];
        for (int j = 0; j < columnas; j++)
        {
            resultado[j] = datos[fila, j];
        }
        return resultado;
    }

    public double[] GetColumna(int columna)
    {
        double[] resultado = new double[filas];
        for (int i = 0; i < filas; i++)
        {
            resultado[i] = datos[i, columna];
        }
        return resultado;
    }

    public double[] DiagonalPrincipal
    {
        get
        {
            int n = Math.Min(filas, columnas);
            double[] diag = new double[n];
            for (int i = 0; i < n; i++)
            {
                diag[i] = datos[i, i];
            }
            return diag;
        }
    }

    public double[] DiagonalSecundaria
    {
        get
        {
            int n = Math.Min(filas, columnas);
            double[] diag = new double[n];
            for (int i = 0; i < n; i++)
            {
                diag[i] = datos[i, columnas - 1 - i];
            }
            return diag;
        }
    }

    public double[][] getArregloDeArreglo()
    {
        double[][] resultado = new double[filas][];
        for (int i = 0; i < filas; i++)
        {
            resultado[i] = new double[columnas];
            for (int j = 0; j < columnas; j++)
            {
                resultado[i][j] = datos[i, j];
            }
        }
        return resultado;
    }

    public void sumarle(Matriz m)
    {
        if (filas != m.filas || columnas != m.columnas)
        {
            Console.WriteLine("No se pueden sumar matrices de distinto tamaño");
            return;
        }

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                datos[i, j] += m.datos[i, j];
            }
        }
    }

    public void restarle(Matriz m)
    {
        if (filas != m.filas || columnas != m.columnas)
        {
            Console.WriteLine("No se pueden restar matrices de distinto tamaño");
            return;
        }

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                datos[i, j] -= m.datos[i, j];
            }
        }
    }

    public void multiplicarPor(Matriz m)
    {
        if (columnas != m.filas)
        {
            Console.WriteLine("No se pueden multiplicar las matrices");
            return;
        }

        double[,] resultado = new double[filas, m.columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < m.columnas; j++)
            {
                for (int k = 0; k < columnas; k++)
                {
                    resultado[i, j] += datos[i, k] * m.datos[k, j];
                }
            }
        }

        datos = resultado;
        columnas = m.columnas;
    }
}
