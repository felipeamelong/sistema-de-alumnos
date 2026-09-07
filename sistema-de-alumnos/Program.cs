using sistema_de_alumnos;

List<Alumno> listaAlumnos = new List<Alumno>();
List<Persona> listaPersonas = new List<Persona>();
List<Materia> listaMaterias = new List<Materia>();
List<IExportable> listaExportables = new List<IExportable>();
bool salir = false;

while (!salir)
{
    Console.WriteLine();
    Console.WriteLine("--- MENÚ DE GESTIÓN DE ALUMNOS ---");
    Console.WriteLine("1. Agregar un alumno");
    Console.WriteLine("2. Agregar un profesor");
    Console.WriteLine("3. Agregar un preceptor");
    Console.WriteLine("4. Agregar una materia");
    Console.WriteLine("5. Listar todos los alumnos");
    Console.WriteLine("6. Buscar un alumno por legajo");
    Console.WriteLine("7. Mostrar el promedio general del curso");
    Console.WriteLine("8. Mostrar cuántos alumnos están aprobados");
    Console.WriteLine("9. Presentar a todas las personas");
    Console.WriteLine("10. Exportar listado");
    Console.WriteLine("11. Salir");
    Console.Write("Elija una opción: ");
    int opcion = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese el nombre del alumno: ");
            string nombreAlumno = Console.ReadLine();
            Console.Write("Ingrese el legajo del alumno: ");
            if (int.TryParse(Console.ReadLine(), out int legajo))
            {
                Alumno nuevoAlumno = new Alumno(nombreAlumno, legajo);

                Console.Write("Ingrese la Nota 1 (0 a 10): ");
                double.TryParse(Console.ReadLine(), out double nota1);

                Console.Write("Ingrese la Nota 2 (0 a 10): ");
                double.TryParse(Console.ReadLine(), out double nota2);

                bool notasCargadas = nuevoAlumno.CargarNotas(nota1, nota2);
                if (notasCargadas)
                {
                    listaAlumnos.Add(nuevoAlumno);
                    listaPersonas.Add(nuevoAlumno);
                    listaExportables.Add(nuevoAlumno);
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
            Console.Write("Ingrese el nombre del profesor: ");
            string nombreProfesor = Console.ReadLine();
            Console.Write("Ingrese el legajo del profesor: ");
            if (int.TryParse(Console.ReadLine(), out int legajoProfesor))
            {
                Console.Write("Ingrese la materia que dicta: ");
                string materia = Console.ReadLine();
                
                Profesor nuevoProfesor = new Profesor(nombreProfesor, legajoProfesor, materia);
                
                listaPersonas.Add(nuevoProfesor);
                listaExportables.Add(nuevoProfesor);
                Console.WriteLine("Profesor cargado correctamente");
            }
            else
            {
                Console.WriteLine("Legajo inválido. Debe ser un número entero");
            }
            break;
        case 3:
            Console.Write("Ingrese el nombre del preceptor: ");
            string nombrePreceptor = Console.ReadLine();
            Console.Write("Ingrese el legajo del preceptor: ");
            if (int.TryParse(Console.ReadLine(), out int legajoPreceptor))
            {
                Preceptor nuevoPreceptor = new Preceptor(nombrePreceptor, legajoPreceptor);
                
                listaPersonas.Add(nuevoPreceptor);
                Console.WriteLine("Preceptor cargado correctamente");
            }
            else
            {
                Console.WriteLine("Legajo inválido. Debe ser un número entero");
            }
            break;
        case 4:
            Console.Write("Ingrese el nombre de la materia: ");
            string nombreMateria = Console.ReadLine();
            Console.Write("Ingrese el codigo del materia: ");
            string codigoMateria = Console.ReadLine();
            Console.Write("Ingrese la cantidad de horas de la materia: ");
            if (int.TryParse(Console.ReadLine(), out int horasMateria))
            {
                Materia nuevaMateria = new Materia(nombreMateria, codigoMateria, horasMateria);
                
                listaMaterias.Add(nuevaMateria);
                listaExportables.Add(nuevaMateria);
                Console.WriteLine("Materia cargada correctamente");
            }
            else
            {
                Console.WriteLine("Horas inválidas. Debe ser un número entero");
            }
            break;
        case 5:
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
        case 6:
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
        case 7:
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
        case 8:
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
        case 9:
            if (listaPersonas.Count == 0)
            {
                Console.WriteLine("No hay personas cargadas en el sistema.");
            }
            else
            {
                Console.WriteLine("--- PRESENTACION DE PERSONAS ---");
                foreach (Persona persona in listaPersonas)
                {
                    persona.Presentarse();
                }
            }
            break;
        case 10:
            if (listaPersonas.Count == 0 && listaMaterias.Count == 0)
            {
                Console.WriteLine("No hay datos cargados en el sistema.");
            }
            else
            {
                Console.WriteLine("--- EXPORTABLE ---");
                foreach (IExportable exportable in listaExportables)
                {
                    Console.WriteLine(exportable.ExportarLinea());
                }
            } 
            break;
        case 11:
            salir = true;
            break;
        default:
            Console.WriteLine("Opción inválida. Por favor, elija una opción del 1 al 11.");
            break;
    }
}