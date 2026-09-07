namespace sistema_de_alumnos;

public class Preceptor : Persona
{
    public Preceptor(string nombre, int legajo) : base(nombre, legajo){}

    public override void Presentarse()
    {
        Console.WriteLine($"Hola, soy {Nombre}, preceptor con legajo {Legajo}"); ;
    }
}