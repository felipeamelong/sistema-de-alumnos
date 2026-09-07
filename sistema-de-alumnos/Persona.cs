namespace sistema_de_alumnos;

public class Persona
{
    public string Nombre { get; set; }
    public int Legajo { get; private set; }
    public Persona (string nombre, int legajo)
    {
        Nombre = nombre;
        Legajo = legajo;
    }

    public virtual void Presentarse()
    {
        Console.WriteLine($"Hola, soy {Nombre}"); ;
    }
}