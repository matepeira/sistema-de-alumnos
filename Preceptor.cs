namespace sistema_de_alumnos;

internal class Preceptor : Persona
{
    public string Curso {  get; set; }

    public Preceptor(string nombre, int documento, string curso)
        : base(nombre, documento)
    {
        Curso = curso;
    }

    public override string Presentarse()
    {
        return $"{base.Presentarse()}, y mi curso a cargo es {Curso} ";

    }
}
