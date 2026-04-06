// 15) Contar Frecuencia de Palabras en Texto.
//     a) Crear un método ContarFrecuenciaPalabras que reciba una cadena de texto y devuelva un diccionario con el conteo de cada palabra.
//     b) El conteo debe ser insensible a mayúsculas/minúsculas (tratar "Hola" y "hola" como iguales).
//     c) Dentro del método, procesar el texto para separar las palabras. Considerar usar texto.Split() separando por espacios y 
//        signos de puntuación comunes.
//     d) Utilizar y devolver un Dictionary<string, int> donde la clave es la palabra y el valor su frecuencia.
//     e) Probar el método: Llamarlo con un texto de ejemplo y mostrar en consola cada palabra y su frecuencia del diccionario 
//        resultante.

//     Ejemplo de Salida Esperada (para "Hola, hola. Me escuchan? o no me escuchan?"):

//     hola: 2
//     me: 2
//     escuchan: 2
//     o: 1
//     no: 1

Dictionary<string, int> ContarFrecuenciaPalabras(string texto)
{
    Dictionary<string, int> diccionario = new Dictionary<string, int>();

    texto = texto.ToLower();

    char[] separadores = { ' ', ',', '.', '?', '¿', '!', '¡', ';', ':', '\n', '\t' };
    string[] palabras = texto.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

    foreach (string palabra in palabras)
    {
        if (diccionario.ContainsKey(palabra))
            diccionario[palabra]++;
        else
            diccionario[palabra] = 1;
    }

    return diccionario;
}

string texto = "Hola, hola. Me escuchan? o no me escuchan?";

var resultado = ContarFrecuenciaPalabras(texto);

foreach (var par in resultado)
{
    Console.WriteLine($"{par.Key}: {par.Value}");
}