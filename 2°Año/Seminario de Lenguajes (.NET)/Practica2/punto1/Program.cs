// 1) Sea el siguiente código:
//      object o1 = "A";
//      object o2 = o1;
//      o2 = "Z";
//      Console.WriteLine(o1 + " " + o2);
//    El tipo object es un tipo referencia, por lo tanto luego de la sentencia o2 = o1 ambas variables están
//    apuntando a la misma dirección. ¿Cómo explica entonces que el resultado en la consola no sea “Z Z”?

Console.WriteLine("No es Z Z ya que el object o2  al hacer o2=Z cambia la referencia al string Z");