namespace sistema_de_alumnos;

public class Profesor : Persona
{
    public string Materia { get; set; }
    
    public Profesor( string nombre, int legajo, string materia) : base(nombre, legajo){}
}