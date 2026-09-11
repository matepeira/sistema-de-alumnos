namespace sistema_de_alumnos;

public class Profesor : Persona
{
    public string Materia {  get; set; }

    public Profesor(string nombre, int documento, string materia)
        : base (nombre, documento)
    {
        Materia = materia;
    }

    public override string Presentarse()
    {
        return $"{ base.Presentarse()}, y dicto {Materia} ";
    }
}
