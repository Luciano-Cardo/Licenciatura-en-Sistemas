// 14) Determinar qué hace el siguiente programa y explicar qué sucede si no se pasan parámetros cuando se invoca desde la línea 
//     de comandos.

Console.WriteLine("¡Hola {0}!", args[0]);

Console.WriteLine("Lo que hace es imprimir el primer elemento pasado por la linea de comando");
Console.WriteLine("Lo que sucede cuando se invoca desde la linea de comando pero no se mandan parametros es que va a estar fuera del rango, ya que en la posicion 0 no va a haber nada");