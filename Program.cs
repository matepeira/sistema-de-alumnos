using sistema_de_alumnos;
using SistemaDeAlumnos;

List<Persona> personas = new List<Persona>
{
    new Alumno("Ana Pérez", 47234567, 1234),
    new Profesor("Marta Díaz", 30987654, "Programación"),
    new Preceptor("Jose Lopez", 25994123, "5 B"),
};

foreach (Persona p in personas)
{   
    Console.WriteLine(p.Presentarse());
}

List<Alumno> Alumnos = new List<Alumno>();
bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n--- MENU DE ALUMNOS ---");
    Console.WriteLine("1- Agregar un alumno");
    Console.WriteLine("2- Listar todos los alumnos");
    Console.WriteLine("3- Buscar un alumno");
    Console.WriteLine("4- Mostrar promedio general del curso");
    Console.WriteLine("5- Mostrar alumnos aprobados");
    Console.WriteLine("6- Salir");
    Console.Write("Seleccione la opcion por su numero: ");

    int.TryParse(Console.ReadLine(), out int opcion);

    switch (opcion)
    {
        case 1:
            Console.WriteLine("\n-- AGREGAR UN ALUMNO --");

            Console.Write("\nIngrese el nombre del alumno: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el documento: ");
            int.TryParse(Console.ReadLine(), out int documento);

            Console.Write("Ingrese el legajo del alumno: ");
            int.TryParse(Console.ReadLine(), out int legajo);

            bool legajoRepetido = false;
            foreach (Alumno alumno in Alumnos)
            {
                if (alumno.Legajo == legajo)
                {
                    legajoRepetido = true;
                    break;
                }
            }

            if (legajoRepetido)
            {
                Console.WriteLine("Error: Ya existe un alumno registrado con ese legajo.");
                break; 
            }

            Console.Write("Ingrese la Nota 1 (Decimales con coma): ");
            decimal.TryParse(Console.ReadLine(), out decimal nota1);

            Console.Write("Ingrese la Nota 2 (Decimales con coma) (0 a 10): ");
            decimal.TryParse(Console.ReadLine(), out decimal nota2);

            Alumno nuevoAlumno = new Alumno(nombre, documento, legajo);


            if(nuevoAlumno.CargarNotas( nota1, nota2))
            {
                Alumnos.Add(nuevoAlumno);
                Console.WriteLine("Alumno agregado exitosamente a la lista.");
            }

            else
            {
                Console.WriteLine("Error: Las notas deben estar entre 0 y 10.");
            }

            break;

        case 2:
            Console.WriteLine("\n-- LISTA DE ALUMNOS --");

            if(Alumnos.Count == 0)
            {
                Console.WriteLine("No hay alumnos registrados");
            }
            else
            {
                foreach (Alumno alumno in Alumnos)
                {
                    Console.WriteLine(alumno.ToString());
                }
            }
            break;

        case 3:
            Console.WriteLine("\n-- BUSCAR ALUMNO POR LEGAJO --");

            Console.Write("Ingrese el legajo del alumno: ");
            int.TryParse(Console.ReadLine(), out int legajoBuscado);
            bool legajoEncontrado = false;

            foreach(Alumno alumno in Alumnos)
            {
                if (legajoBuscado == alumno.Legajo)
                {
                    Console.WriteLine(alumno.ToString());
                    legajoEncontrado = true;
                    break;
                }

                if (!legajoEncontrado)
                {
                    Console.WriteLine("El legajo del alumno no fue encontrado.");
                }
                break;
            }
            break;

        case 4:
            Console.WriteLine("\n-- MOSTRAR PROMEDIO DEL CURSO --");

            if (Alumnos.Count == 0)
            {
                Console.WriteLine("No hay alumnos registrados");
            }
            else
            {
                decimal sumaPromedios = 0;

                foreach (Alumno alumno in Alumnos)
                {
                    sumaPromedios += alumno.Promedio();
                }

                decimal promedioGeneral = sumaPromedios / Alumnos.Count;
                Console.WriteLine($"El promedio general del curso es: {promedioGeneral}");
            }
            break;

        case 5:
            Console.WriteLine("\n-- MOSTRAR CUANTOS ALUMNOS APROBADOS DEL CURSO --");

                if (Alumnos.Count == 0)
                {
                    Console.WriteLine("No hay alumnos registrados todavía.");
                }
                else
                {
                    int aprobados = 0;

                foreach (Alumno alumno in Alumnos)
                {
                    if (alumno.EstaAprobado())
                    {
                        aprobados++;
                    }
                }
                Console.WriteLine($"Cantidad de alumnos aprobados: {aprobados} de {Alumnos.Count}");

            }
            break;

        case 6:
            Console.WriteLine("Saliendo del programa");
            continuar = false;
            break;

        default:
            Console.WriteLine("Opcion invalida, ingrese un numero del uno al 6");
            break;
    }
}