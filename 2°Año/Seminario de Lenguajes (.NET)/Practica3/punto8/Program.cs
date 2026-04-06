// 8) Señalar errores de compilación y/o ejecución en el siguiente código

// object obj = new int[10];
// dynamic dyna = 13;
// Console.WriteLine(obj.Length);
// Console.WriteLine(dyna.Length)

Console.WriteLine("obj no contiene una definicion para Lenght, se soluciona con ((int[]obj).Lenght)");
Console.WriteLine("En runtime el error es en dyna.Lenght ya que int no contiene una deficion para Lenght");