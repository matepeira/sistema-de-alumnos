using SistemaDeAlumnos;

Alumno alumnoUno = new Alumno()
{
    Nombre = "Pepe",
    Legajo = 1,
    Nota1 = 7.0m,
    Nota2 = 8.5m,
};

Alumno alumnoDos = new Alumno()
{
    Nombre = "Maria",
    Legajo = 2,
    Nota1 = 5.2m,
    Nota2 = 9.5m,
};

Console.WriteLine($"Nombre del alumno: {alumnoUno.Nombre}, Legajo: {alumnoUno.Legajo}");
Console.WriteLine($"Nombre del alumno: {alumnoDos.Nombre}, Legajo: {alumnoDos.Legajo}");