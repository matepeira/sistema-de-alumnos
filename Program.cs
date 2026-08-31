using SistemaDeAlumnos;

Alumno alumnoUno = new Alumno("Martin Ventu", 2);
Alumno alumnoDos = new Alumno("Jose Sanchez", 1);

if (alumnoUno.CargarNotas(9.2m, 4.0m))
{
    Console.WriteLine($"Notas cargadas correctamente para: {alumnoUno.Nombre}| {alumnoUno}");
}
else
{
    Console.WriteLine("No se pudieron cargar las notas, ingrese un valor valido");
}

if (alumnoDos.CargarNotas(47m, 8.0m))
{
    Console.WriteLine($"Notas cargadas correctamente para: {alumnoDos.Nombre}| {alumnoDos}");
}
else
{
    Console.WriteLine("No se pudieron cargar las notas, ingrese un valor valido");
}
