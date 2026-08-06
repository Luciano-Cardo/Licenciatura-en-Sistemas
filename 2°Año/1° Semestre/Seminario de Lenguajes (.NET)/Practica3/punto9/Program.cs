// 9) ¿Qué líneas del siguiente método provocan error de compilación y por qué?

// var a = 3L;
// dynamic b = 32;
// object obj = 3;
// a = a * 2.0; No se puede asignar double a Long sin cast
// b = b * 2.0; 
// b = "hola";
// obj = b;
// b = b + 11;
// obj = obj + 11; object no soporta el operador +
// var c = new { Nombre = "Juan" };
// var d = new { Nombre = "María" };
// var e = new { Nombre = "Maria", Edad = 20 };
// var f = new { Edad = 20, Nombre = "Maria" };
// f.Edad = 22; Los tipos anonimos son inmutables(read only)
// d = c;
// e = d; Son tipos anonimos diferentes
// f = e; Son tipos anonimos diferentes