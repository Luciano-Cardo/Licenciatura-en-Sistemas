// 1)  Responder sobre el siguiente código
   
//     -----------Program.cs-----------
//     AccionInt a1 = (ref int i) => i = i * 2;
//     a1 += a1;
//     a1 += a1;
//     a1 += a1;
//     int i = 1;
//     a1(ref i);
//     -----------AccionInt.cs-----------
//     delegate void AccionInt(ref int i);

//     ¿Cuál es el tamaño de la lista de invocación de a1 y cual es el valor de la variable i luego de la invocación a1(ref i)?

Console.WriteLine("La lista de invocación del delegado a1 tiene un tamaño de 8 elementos. Esto sucede porque inicialmente contiene un método y " +
                  "cada instrucción a1 += a1 duplica la cantidad de métodos en la lista de invocación: pasa de 1 a 2, luego a 4 y finalmente " +
                  "a 8.");
Console.WriteLine("Por otro lado, la variable i comienza con el valor 1 y cada método del delegado realiza la operación i = i * 2. Como dicha " + 
                  "operación se ejecuta 8 veces, el valor final resulta: 1*2^8=256");
Console.WriteLine("Por lo tanto, luego de ejecutar a1(ref i), el valor final de i es 256.");