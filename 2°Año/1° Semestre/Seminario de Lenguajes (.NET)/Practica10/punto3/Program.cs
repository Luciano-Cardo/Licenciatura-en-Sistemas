// 3)  Supongamos que tenemos la siguiente información sobre alumnos, cursos y exámenes estructurada de esta manera:
//     Podemos ver, por ejemplo, que Ana sacó 5 en un examen de Inglés y 8 en un examen de Geografía, Juan no rindió ningún examen y nadie rindió 
//     examen en el curso de Matemáticas.
//     Definir las clases Alumno, Examen y Curso. Establecer por código las listas alumnos (de tipo List<Alumno>), examenes (de tipo List<Examen>) y 
//     cursos (de tipo List<Curso>) con los datos que se muestran en la imagen anterior y resolver utilizando LINQ:

//     a)  Obtener el listado con los nombres de los alumnos que rindieron al menos un examen, ordenado alfabéticamente (tip: puede utilizarse el 
//         método de extensión Distint() para obtener una secuencia de elementos no repetidos). La salida debería ser:
//         Salida por consola
//         Ana
//         Andrés
//         Camila
//         María
//         Paula
//         Raúl
//     b)  Obtener el listado con los cursos donde se hayan rendido exámenes. Se debe listar el título del curso junto con la cantidad de exámenes. 
//         El listado debe ordenarse por cantidad de exámenes. La salida debería ser:
//         Salida por consola
//         { Título = Inglés, Cantidad = 2 }
//         { Título = Historia, Cantidad = 2 }
//         { Título = Literatura, Cantidad = 3 }
//         { Título = Geografía, Cantidad = 4 }
//     c)  Obtener el listado con los alumnos que hayan rendido al menos un exámen informando el nombre del alumno, el título del curso y la nota del 
//         examen. La salida debería ser:
//         Salida por consola
//         { Alumno = Ana, Curso = Inglés, Nota = 5 }
//         { Alumno = Ana, Curso = Geografía, Nota = 8 }
//         { Alumno = Andrés, Curso = Geografía, Nota = 10 }
//         { Alumno = Paula, Curso = Literatura, Nota = 7 }
//         { Alumno = Paula, Curso = Historia, Nota = 9 }
//         { Alumno = María, Curso = Literatura, Nota = 9 }
//         { Alumno = María, Curso = Geografía, Nota = 5 }
//         { Alumno = Camila, Curso = Historia, Nota = 5 }
//         { Alumno = Camila, Curso = Literatura, Nota = 9 }
//         { Alumno = Raúl, Curso = Inglés, Nota = 7 }
//         { Alumno = Raúl, Curso = Geografía, Nota = 1 }
//     d)  Filtrar el listado del punto anterior para mostrar sólo los casos aprobados (nota >=6).
//     e)  Obtener el listado con los nombres de los alumnos que no han rendido ningún examen.
//     f)  Obtener el listado de los alumnos que hayan rendido algún examen junto con el promedio de todos sus exámenes. La salida debería ser:
//         Salida por consola
//         { Alumno = Ana, Promedio = 6,5 }
//         { Alumno = Andrés, Promedio = 10 }
//         { Alumno = Paula, Promedio = 8 }
//         { Alumno = María, Promedio = 7 }
//         { Alumno = Camila, Promedio = 7 }
//         { Alumno = Raúl, Promedio = 4 }

List<Alumno> alumnos =
[
    new Alumno { Id = 1, Nombre = "Juan" },
    new Alumno { Id = 2, Nombre = "Ana" },
    new Alumno { Id = 3, Nombre = "Andrés" },
    new Alumno { Id = 4, Nombre = "Paula" },
    new Alumno { Id = 5, Nombre = "Sebastián" },
    new Alumno { Id = 6, Nombre = "María" },
    new Alumno { Id = 7, Nombre = "Camila" },
    new Alumno { Id = 8, Nombre = "Iván" },
    new Alumno { Id = 9, Nombre = "Raúl" }
];

List<Curso> cursos =
[
    new Curso { Id = 1, Titulo = "Inglés" },
    new Curso { Id = 2, Titulo = "Matemática" },
    new Curso { Id = 3, Titulo = "Historia" },
    new Curso { Id = 4, Titulo = "Geografía" },
    new Curso { Id = 5, Titulo = "Literatura" },
    new Curso { Id = 6, Titulo = "Contabilidad" }
];

List<Examen> examenes =
[
    new Examen { AlumnoId = 2, Nota = 5, CursoId = 1 },
    new Examen { AlumnoId = 4, Nota = 7, CursoId = 5 },
    new Examen { AlumnoId = 4, Nota = 9, CursoId = 3 },
    new Examen { AlumnoId = 3, Nota = 10, CursoId = 4 },
    new Examen { AlumnoId = 7, Nota = 5, CursoId = 3 },
    new Examen { AlumnoId = 2, Nota = 8, CursoId = 4 },
    new Examen { AlumnoId = 6, Nota = 9, CursoId = 5 },
    new Examen { AlumnoId = 9, Nota = 7, CursoId = 1 },
    new Examen { AlumnoId = 6, Nota = 5, CursoId = 4 },
    new Examen { AlumnoId = 9, Nota = 1, CursoId = 4 },
    new Examen { AlumnoId = 7, Nota = 9, CursoId = 5 }
];

alumnos.Join(examenes,
             a => a.Id,
             e => e.AlumnoId,
             (a, e) => a.Nombre)
       .Distinct()
       .OrderBy(n => n)
       .ToList()
       .ForEach(Console.WriteLine);