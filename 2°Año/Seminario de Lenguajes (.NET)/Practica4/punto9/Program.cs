// 9) ¿Qué se puede decir en relación a la sobrecarga de métodos en este ejemplo?

//     class A
//     {
//         public void Metodo(short n) {
//             Console.Write("short {0} - ", n);
//         }
//         public void Metodo(int n) {
//             Console.Write("int {0} - ", n);
//         }
//         public int Metodo(int n) {
//             return n + 10;
//         }
//     }

Console.WriteLine("En el ejemplo, la sobrecarga entre Metodo(short) y Metodo(int) es válida porque difieren en el tipo de "+
                  "parámetro. Sin embargo, los métodos Metodo(int) con distinto tipo de retorno (void e int) no constituyen "+
                  "una sobrecarga válida en C#, ya que el tipo de retorno no forma parte de la firma del método, lo que produce"+ 
                  "un error de compilación.");