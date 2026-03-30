// 5) Idem. al ejercicio anterior salvo que se imprimirá un mensaje de saludo diferente según sea el
//    nombre ingresado por el usuario. Así para “Juan” debe imprimir “¡Hola amigo!”, para “María” debe
//    imprimir “Buen día señora”, para “Alberto” debe imprimir “Hola Alberto”. En otro caso, debe
//    imprimir “Buen día ” seguido del nombre ingresado o “¡Buen día mundo!” si se ha ingresado una línea
//    vacía.
//      a) utilizando if ... else if
//      b) utilizando switch

//A
Console.WriteLine("Ingresa tu nombre");
string nombre = Console.ReadLine();
if (nombre == "Juan"){
    Console.WriteLine("¡Hola amigo!");
}else if (nombre == "Maria"){
    Console.WriteLine("Buen dia señora"); 
}else if (nombre == "Alberto"){
    Console.WriteLine("Hola Alberto");
}else if (nombre != ""){
    Console.WriteLine("Hola " +nombre);
}else{
    Console.WriteLine("¡Buen dia mundo!");
}


//B
switch (nombre)
{
    case "Juan":
        Console.WriteLine("¡Hola amigo!");
        break;
    case "Maria":
        Console.WriteLine("Buen dia señora");
        break;
    case "Alberto":
        Console.WriteLine("Hola Alberto");
        break;
    case "":
        Console.WriteLine("¡Buen dia mundo!");
        break;
    default:
        Console.WriteLine("Hola " +nombre);
        break;
}