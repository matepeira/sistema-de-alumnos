namespace SistemaDeAlumnos;

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

    public override string ToString()
    {
        return $"{Nombre} - {Legajo} - (Promedio: {Promedio()})";
    }
}
