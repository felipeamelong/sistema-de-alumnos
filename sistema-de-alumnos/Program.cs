using sistema_de_alumnos;

Alumno alumno1 = new Alumno("Tomás", 1, 9, 7);
Alumno alumno2 = new Alumno("Facundo", 2, 8.53m, 9.02m);

Console.WriteLine($"Alumno 1:\nNombre: {alumno1.Nombre}\nLegajo: {alumno1.Legajo}");
Console.WriteLine();
Console.WriteLine($"Alumno 2:\nNombre: {alumno2.Nombre}\nLegajo: {alumno2.Legajo}");

alumno1.Nombre = "Juan";

Console.WriteLine($"Alumno 1:\nNombre: {alumno1.Nombre}\nLegajo: {alumno1.Legajo}");
Console.WriteLine();
Console.WriteLine($"Alumno 2:\nNombre: {alumno2.Nombre}\nLegajo: {alumno2.Legajo}");