namespace sistema_de_alumnos;

public class Materia : IExportable
{
    public string Nombre;
    public string Codigo;
    public int Horas;

    public Materia(string nombre, string codigo, int horas)
    {
        Nombre = nombre;
        Codigo = codigo;
        Horas = horas;
    }
    
    public string ExportarLinea()
    {
        return $"MATERIA;{Codigo};{Nombre};{Horas}";
    }
}