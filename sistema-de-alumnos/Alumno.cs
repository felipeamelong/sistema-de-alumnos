namespace sistema_de_alumnos;

public class Alumno
{
    public string Nombre { get; set; }
    public int Legajo { get; set; }
    public decimal Nota1 { get; set; }
    public decimal Nota2 { get; set; }
    public Alumno(string nombre, int legajo, decimal nota1, decimal nota2)
    {
        Nombre = nombre;
        Legajo = legajo;
        Nota1 = nota1;
        Nota2 = nota2;
    }
    public decimal Promedio()
    {
        decimal promedio = (Nota1 + Nota2) / 2;
        return promedio;
    }
    public bool EstaAprobado()
    {
        return Promedio() >= 6;
    }
    public void SubirNota()
    {
        Nota1 += 1;
        Nota2 += 1;
        if (Nota1 > 10)
        {
            Nota1 = 10;
        }
        if (Nota2 > 10)
        {
            Nota2 = 10;
        }
    }
}