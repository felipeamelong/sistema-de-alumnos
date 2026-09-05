using sistema_de_alumnos;

List<Alumno> listaAlumnos = new List<Alumno>();
bool salir = false;

while (!salir)
{
    Console.WriteLine();
    Console.WriteLine("--- MENÚ DE GESTIÓN DE ALUMNOS ---");
    Console.WriteLine("1. Agregar un alumno");
    Console.WriteLine("2. Listar todos los alumnos");
    Console.WriteLine("3. Buscar un alumno por legajo");
    Console.WriteLine("4. Mostrar el promedio general del curso");
    Console.WriteLine("5. Mostrar cuántos alumnos están aprobados");
    Console.WriteLine("6. Salir");
    Console.Write("Elija una opción: ");
    int opcion = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese el nombre del alumno: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el legajo del alumno: ");
            if (int.TryParse(Console.ReadLine(), out int legajo))
            {
                Alumno nuevoAlumno = new Alumno(nombre, legajo);

                Console.Write("Ingrese la Nota 1 (0 a 10): ");
                double.TryParse(Console.ReadLine(), out double nota1);

                Console.Write("Ingrese la Nota 2 (0 a 10): ");
                double.TryParse(Console.ReadLine(), out double nota2);

                bool notasCargadas = nuevoAlumno.CargarNotas(nota1, nota2);
                if (notasCargadas)
                {
                    listaAlumnos.Add(nuevoAlumno);
                    Console.WriteLine("Alumno cargado correctamente");
                }
                else
                {
                    Console.WriteLine("Notas inválidas. El alumno no fue cargado al sistema.");
                }
            }
            else
            {
                Console.WriteLine("Legajo inválido. Debe ser un número entero");
            }

            break;
        case 2:
            if (listaAlumnos.Count == 0)
            {
                Console.WriteLine("No hay alumnos registrados en el sistema.");
            }
            else
            {
                Console.WriteLine("--- LISTA DE ALUMNOS ---");
                foreach (Alumno alumno in listaAlumnos)
                {
                    Console.WriteLine(alumno);
                }
            }

            break;
        case 3:
            Console.Write("Ingrese el legajo del alumno a buscar: ");
            if (int.TryParse(Console.ReadLine(), out int legajoBusqueda))
            {
                Alumno alumnoEncontrado = null;
                foreach (Alumno alumno in listaAlumnos)
                {
                    if (alumno.Legajo == legajoBusqueda)
                    {
                        alumnoEncontrado = alumno;
                        break;
                    }
                }

                if (alumnoEncontrado != null)
                {
                    Console.WriteLine("Alumno encontrado!");
                    Console.WriteLine(alumnoEncontrado);
                }
                else
                {
                    Console.WriteLine("No existe ningún alumno con ese legajo.");
                }
            }
            else
            {
                Console.WriteLine("Legajo inválido. Debe ser un número entero");
            }

            break;
        case 4:
            if (listaAlumnos.Count == 0)
            {
                Console.WriteLine("No hay alumnos cargados para calcular el promedio general.");
            }
            else
            {
                double sumaPromedios = 0;
                foreach (Alumno alumno in listaAlumnos)
                {
                    sumaPromedios += alumno.Promedio();
                }
                double promedioGeneral = sumaPromedios / listaAlumnos.Count;
                Console.WriteLine($"Promedio general: {promedioGeneral}");
            }
            break;
        case 5:
            if (listaAlumnos.Count == 0)
            {
                Console.WriteLine("No hay alumnos cargados en el sistema.");
            }
            else
            {
                int alumnosAprobados = 0;
                foreach (Alumno alumno in listaAlumnos)
                {
                    if (alumno.EstaAprobado())
                    {
                        alumnosAprobados++;
                    }
                }
                Console.WriteLine($"Cantidad de alumnos aprobados: {alumnosAprobados} de {listaAlumnos.Count}");
            }
            break;
        case 6:
            salir = true;
            break;
        default:
            Console.WriteLine("Opción inválida. Por favor, elija una opción del 1 al 6.");
            break;
    }
}