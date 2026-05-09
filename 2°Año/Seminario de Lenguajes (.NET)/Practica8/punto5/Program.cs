// 5)  Codificar la clase Temporizador con un evento Tic que se genera cada cierto intervalo de tiempo medido en milisegundos una vez que el 
//     temporizador se haya habilitado. La clase debe contar con dos propiedades: Intervalo de tipo int y Habilitado de tipo bool. No se debe permitir
//     establecer la propiedad Habilitado en true si no existe ninguna suscripción al evento Tic. No se debe permitir establecer el valor de Intervalo
//     menor a 100. En el lanzamiento del evento, el temporizador debe  informar la cantidad de veces que se provocó el evento. Para detener los 
//     eventos debe establecerse la propiedad Habilitado en false. A modo de ejemplo, el siguiente código debe producir la salida indicada.

//     Temporizador t = new Temporizador();
//     t.Tic += (sender, e) =>
//     {
//          Console.WriteLine(DateTime.Now.ToString("HH:mm:ss") + " ");
//          if (e.Tics == 5)
//          {
//              t.Habilitado = false;
//           }
//      };
//      t.Intervalo = 2000;
//      t.Habilitado = true;

using punto5;

Temporizador t = new Temporizador();
t.Tic += (sender, e) =>
{
    Console.WriteLine(DateTime.Now.ToString("HH:mm:ss") + " ");
    if (e.Tics == 5)
    {
        t.Habilitado = false;
    }
};
t.Intervalo = 2000;
t.Habilitado = true;