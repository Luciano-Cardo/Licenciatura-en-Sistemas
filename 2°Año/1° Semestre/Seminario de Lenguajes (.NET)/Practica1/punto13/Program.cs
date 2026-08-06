// 13) Si a y b son variables enteras, identificar el problema (y la forma de resolverlo) de la siguiente expresión. 
//     Tip: observar qué pasa cuando b = 0.

//     if ((b != 0) & (a/b > 5)) Console.WriteLine(a/b);

Console.WriteLine("El problema es en el & ya que evalua las 2 condiciones, se puede solucionar colacando && ya que corta y no evalua la segunda condicion");

if ((b != 0) && (a/b > 5)) Console.WriteLine(a/b);//Solucion
