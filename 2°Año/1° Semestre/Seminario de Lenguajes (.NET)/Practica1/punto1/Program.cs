// 1) Consultar en la documentación de Microsoft y responder cuál es la diferencia entre los métodos
//    WriteLine() y Write() de la clase System.Console ¿Cómo funciona el método ReadKey() de
//    la misma clase? Escribir un programa que imprima en la consola la frase “Hola Mundo” haciendo una
//    pausa entre palabra y palabra esperando a que el usuario presione una tecla para continuar.
//    Tip: usar los métodos ReadKey() y Write() de la clase System.Console

//RTA: La diferencia entre los metodos Write() y Writeline es que el metodo Writeline() hace un salto de linea y
//     y el metodo Write() no.
//     El metodo ReadKey() funciona de tal manera que la maquina se queda esperando a que el usuario presione cualquier
//     tecla para poder continuar.

Console.Write("Hola ");
Console.ReadKey();
Console.Write ("Mundo");

