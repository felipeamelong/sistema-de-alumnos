namespace sistema_de_alumnos;

public class Alumno : Persona
{
    public double Nota1 { get; private set; }
    public double Nota2 { get; private set; }
    
    public Alumno(string nombre, int legajo) : base(nombre, legajo){}
    
    public double Promedio()
    {
        double promedio = (Nota1 + Nota2) / 2;
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

    public override string ToString()
    {
        return $"{Legajo} - {Nombre} (promedio: {Promedio()})";
    }

    public bool CargarNotas(double nota1, double nota2)
    {
        if (nota1 >= 0 && nota1 <= 10 && nota2 >= 0 && nota2 <= 10)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            return true;
        }
        else
        {
            return false;
        }
    }
}