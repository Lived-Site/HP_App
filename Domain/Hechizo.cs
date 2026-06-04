namespace Domain;

public class Hechizo
{
    private static int ultimoId = 0;
    private int IdHechizo { get; set; }
    private string Nombre { get; set; }
    private string Tipo { get; set; }

    public Hechizo(string Nombre, string Tipo)
    {
        this.Nombre = Nombre;
        this.Tipo = Tipo;
        IdHechizo = ++ultimoId;
    }

    public Hechizo()
    {
        IdHechizo = ++ultimoId;
    }
}