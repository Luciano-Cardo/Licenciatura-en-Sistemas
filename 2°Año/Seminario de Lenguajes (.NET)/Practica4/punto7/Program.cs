// 7) Implementar la clase Matriz que se utilizará para trabajar con matrices matemáticas. Implementar los dos constructores y todos 
//    los métodos que se detallan a continuación:
//     public Matriz(int filas, int columnas)
//     public Matriz(double[,] matriz)
//     public void SetElemento(int fila, int columna, double elemento)
//     public double GetElemento(int fila, int columna)
//     public void imprimir()
//     public void imprimir(string formatString)
//     public double[] GetFila(int fila)
//     public double[] GetColumna(int columna)
//     public double[] GetDiagonalPrincipal()
//     public double[] GetDiagonalSecundaria()
//     public double[][] getArregloDeArreglo()
//     public void sumarle(Matriz m)
//     public void restarle(Matriz m)
//     public void multiplicarPor(Matriz m)

namespace punto7
{
    class Program
    {
        static void Main()
        {
            double[,] datos = {
                {1, 2},
                {3, 4}
            };
            Matriz m1 = new Matriz(datos);
            Matriz m2 = new Matriz(datos);
            m1.sumarle(m2);
            m1.imprimir();
            Console.WriteLine("Diagonal principal:");
            foreach (var x in m1.GetDiagonalPrincipal())
            {
                Console.Write(x + " ");
            }
        }
    }
}