using sistema_de_alumnos;

Alumno alumno1 = new Alumno("Tomás", 1);
Alumno alumno2 = new Alumno("Facundo", 2);

bool resultado1 = alumno1.CargarNotas(8, 9);
if (!resultado1)
{
    Console.WriteLine("Notas inválidas. No se cargaron en el sistema");
}
bool resultado2 = alumno2.CargarNotas(8.54, 5);
if (!resultado2)
{
    Console.WriteLine("Notas inválidas. No se cargaron en el sistema");
}

Console.WriteLine(alumno1);
Console.WriteLine(alumno2);
