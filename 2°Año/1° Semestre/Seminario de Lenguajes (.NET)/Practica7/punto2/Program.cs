// 2)  Incorporar al ejercicio anterior la posibilidad también de lavar a los perros. También se debe incorporar una clase derivada de Película, 
//     las “películas clásicas” que además de alquilarse pueden venderse. Estos cambios deben poder realizarse sin necesidad de modificar la clase 
//     estática Procesador.
//     El siguiente código debe producir la salida indicada:
//     Auto auto = new Auto();
//     Libro libro = new Libro();
//     Persona persona = new Persona();
//     Perro perro = new Perro();
//     Pelicula pelicula = new Pelicula();
//     Procesador.Alquilar(pelicula, persona);
//     Procesador.Alquilar(libro, persona);
//     Procesador.Atender(persona);
//     Procesador.Atender(perro);
//     Procesador.Devolver(pelicula, persona);
//     Procesador.Devolver(libro, persona);
//     Procesador.Lavar(auto);
//     Procesador.Reciclar(libro);
//     Procesador.Reciclar(auto);
//     Procesador.Secar(auto);
//     Procesador.Vender(auto, persona);
//     Procesador.Vender(perro, persona);
//     Procesador.Lavar(perro);
//     Procesador.Secar(perro);
//     PeliculaClasica peliculaClasica = new PeliculaClasica();
//     Procesador.Alquilar(peliculaClasica, persona);
//     Procesador.Devolver(peliculaClasica, persona);
//     Procesador.Vender(peliculaClasica, persona);

//     Salida por consola:

//     Alquilando película a persona
//     Alquilando libro a persona
//     Atendiendo persona
//     Atendiendo perro
//     Película devuelta por persona
//     Libro devuelto por persona
//     Lavando auto
//     Reciclando libro
//     Reciclando auto
//     Secando auto
//     Vendiendo auto a persona
//     Vendiendo perro a persona
//     Lavando perro
//     Secando perro
//     Alquilando película clásica a persona
//     Película clásica devuelta por persona
//     Vendiendo película clásica a persona

using punto2;

Auto auto = new Auto();
Libro libro = new Libro();
Persona persona = new Persona();
Perro perro = new Perro();
Pelicula pelicula = new Pelicula();

Procesador.Alquilar(pelicula, persona);
Procesador.Alquilar(libro, persona);
Procesador.Atender(persona);
Procesador.Atender(perro);
Procesador.Devolver(pelicula, persona);
Procesador.Devolver(libro, persona);
Procesador.Lavar(auto);
Procesador.Reciclar(libro);
Procesador.Reciclar(auto);
Procesador.Secar(auto);
Procesador.Vender(auto, persona);
Procesador.Vender(perro, persona);
Procesador.Lavar(perro);
Procesador.Secar(perro);
PeliculaClasica peliculaClasica = new PeliculaClasica();
Procesador.Alquilar(peliculaClasica, persona);
Procesador.Devolver(peliculaClasica, persona);
Procesador.Vender(peliculaClasica, persona);