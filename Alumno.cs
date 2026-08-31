namespace SistemaDeAlumnos;

public class Alumno
{
    public string Nombre { get; set; }
    public int Legajo { get; private set; }
    public decimal Nota1 { get; private set; }
    public decimal Nota2 { get; private set; }

    public Alumno(string nombre, int legajo)
    {
        Nombre = nombre;
        Legajo = legajo;
    }

    public decimal Promedio()
    {
        decimal notasTotal = Nota1 + Nota2;
        return notasTotal / 2.0m;
    }

    public bool EstaAprobado()
    {
        return Promedio() >= 6m;
    }

    public void SubirNota()
    {
        if (Nota1 < 10m)
        {
            Nota1++;
        }

        if (Nota2 < 10m)
        {
            Nota2++;
        }
    }

    public bool CargarNotas(decimal nota1, decimal nota2)
    {   
        if (nota1 >= 0m && nota1 <= 10m && nota2 >= 0m && nota2 <= 10)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            return true;
        }

        return false;
    }

    public override string ToString()
    {
        return $"{Nombre} - {Legajo} - (Promedio: {Promedio()})";
    }
}
