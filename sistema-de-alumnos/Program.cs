using sistema_de_alumnos;

Alumno alumno1 = new Alumno
{
    Nombre = "Tomás",
    Legajo = 1,
    Nota1 = 9,
    Nota2 = 7,
};

Alumno alumno2 = new Alumno
{
    Nombre = "Facundo",
    Legajo = 2,
    Nota1 = 8.53m,
    Nota2 = 9.02m,
};

Console.WriteLine($"Alumno 1:\nNombre: {alumno1.Nombre}\nLegajo: {alumno1.Legajo}");
Console.WriteLine();
Console.WriteLine($"Alumno 2:\nNombre: {alumno2.Nombre}\nLegajo: {alumno2.Legajo}");

alumno1.Nombre = "Juan";

Console.WriteLine($"Alumno 1:\nNombre: {alumno1.Nombre}\nLegajo: {alumno1.Legajo}");
Console.WriteLine();
Console.WriteLine($"Alumno 2:\nNombre: {alumno2.Nombre}\nLegajo: {alumno2.Legajo}");