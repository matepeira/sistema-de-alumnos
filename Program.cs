using SistemaDeAlumnos;

Alumno alumnoUno = new Alumno("Martin Ventu", 2, 9.2m, 4.0m);
Alumno alumnoDos = new Alumno("Jose Sanchez", 1, 8.0m, 9.0m);

Console.WriteLine($"Nombre del alumno: {alumnoUno.Nombre}, Legajo: {alumnoUno.Legajo}");
Console.WriteLine($"Nombre del alumno: {alumnoDos.Nombre}, Legajo: {alumnoDos.Legajo}");