//6) ¿Cuál es la salida por consola del siguiente fragmento de código? ¿Por qué la tercera y sexta línea producen resultados 
//   diferentes?

char c1 = 'A';
char c2 = 'A';
Console.WriteLine(c1 == c2);
object o1 = c1;
object o2 = c2;
Console.WriteLine(o1 == o2);

Console.WriteLine("La salida por consola es true y false");
Console.WriteLine("Producen resultados diferentes ya que o1 y o2 tienen distintas direcciones en la heap");