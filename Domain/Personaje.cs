
namespace Domain;

public class Personaje
{
    private static int ultimoId = 0;
    private int IdPersonaje;
    private string Nombre { get; set; }
    private DateTime fecha_nacimiento { get; set; }
    private string Genero { get; set; }
    private string tipo_raza { get; set; }

    public Personaje(string Nombre, DateTime fecha_nacimiento, string Genero, string tipo_raza)
    {
        IdPersonaje = ++ultimoId;
        this.Nombre = Nombre;
        this.fecha_nacimiento = fecha_nacimiento;
        this.Genero = Genero;
        this.tipo_raza = tipo_raza;
    }

    public Personaje()
    {
        IdPersonaje = ++ultimoId;
    }
    
}