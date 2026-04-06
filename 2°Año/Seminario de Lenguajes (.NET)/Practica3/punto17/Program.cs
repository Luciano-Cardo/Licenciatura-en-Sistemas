// 17) Implementar un programa que permita al usuario ingresar números por la consola. Debe ingresarse un número por línea finalizado
//     el proceso cuando el usuario ingresa una línea vacía. A medida que se van ingresando los valores el sistema debe mostrar por 
//     la consola la suma acumulada de los mismos. Utilizar double.Parse() y try/catch para validar que la entrada ingresada sea un 
//     número válido, en caso contrario advertir con un mensaje al usuario y proseguir con el ingreso de datos.

double suma = 0;

while (true)
{
    Console.Write("Ingrese un número (Enter vacío para terminar): ");
    string input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
        break;

    try
    {
        double numero = double.Parse(input);
        suma += numero;

        Console.WriteLine($"Suma acumulada: {suma}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: debe ingresar un número válido.");
    }
}