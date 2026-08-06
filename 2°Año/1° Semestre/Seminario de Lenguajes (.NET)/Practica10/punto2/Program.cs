// 2)  Listar por consola la cantidad de veces que se repiten los elementos de un vector de enteros. Ordenar por cantidad de repeticiones. 
//     Completar el siguiente código para que la salida por consola sea la indicada.

//     int[] vector = [1, 3, 4, 5, 9, 4, 3, 4, 5, 1, 1, 4, 9, 4, 3, 1];
//     vector.GroupBy(n => n)
//         // . . . completar aquí las líneas que faltan usando fluent API
//         .ForEach(obj => Console.WriteLine(obj));

//     Salida por consola
//     { Numero = 5, Cantidad = 2 }
//     { Numero = 9, Cantidad = 2 }
//     { Numero = 3, Cantidad = 3 }
//     { Numero = 1, Cantidad = 4 }
//     { Numero = 4, Cantidad = 5 } 

int[] vector = [1, 3, 4, 5, 9, 4, 3, 4, 5, 1, 1, 4, 9, 4, 3, 1];

vector.GroupBy(n => n)
      .Select(g => new { Numero = g.Key, Cantidad = g.Count() })
      .OrderBy(x => x.Cantidad)
      .ToList()
      .ForEach(obj => Console.WriteLine(obj));