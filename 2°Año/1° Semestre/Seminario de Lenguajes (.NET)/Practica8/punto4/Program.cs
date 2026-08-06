// 4)  Codificar una clase Ingresador con un método público Ingresar() que permita al usuario ingresar líneas por la consola hasta que se ingrese la 
//     línea con la palabra "fin". Ingresador debe implementar dos eventos. Uno sirve para notificar que se ha ingresado una línea vacía ( "" ). 
//     El otro para indicar que se ha ingresado un valor numérico (debe comunicar el valor del número ingresado como argumento cuando se genera el 
//     evento). A modo de ejemplo observar el siguiente código que hace uso de un objeto Ingresador.

//     Ingresador ingresador = new Ingresador();
//     ingresador.LineaVaciaIngresada += (sender, e) =>
//         { Console.WriteLine("Se ingresó una línea en blanco"); };
//     ingresador.NroIngresado += (sender, e) =>
//         { Console.WriteLine($"Se ingresó el número {e.Valor}"); };
//     ingresador.Ingresar();

using punto4;

Ingresador ingresador = new Ingresador();
ingresador.LineaVaciaIngresada += (sender, e) =>
    { Console.WriteLine("Se ingresó una línea en blanco"); };
ingresador.NroIngresado += (sender, e) =>
    { Console.WriteLine($"Se ingresó el número {e.Valor}"); };
ingresador.Ingresar();