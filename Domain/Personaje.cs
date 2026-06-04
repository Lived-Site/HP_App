
namespace Domain;

public class Personaje
{
    private static int ultimoId = 0;
    public int IdPersonaje { get; private set; }
    private string Nombre { get; set; }
    private string Apellido { get; set; }
    private DateTime fecha_nacimiento { get; set; }
    private string Genero { get; set; }
    private string TipoRaza { get; set; }

    public Personaje(string Nombre, string Apellido, DateTime fecha_nacimiento, string Genero, string tipo_raza)
    {
        if (string.IsNullOrWhiteSpace(Nombre)) 
            throw new ArgumentException("Un personaje no puede nacer sin nombre.");
        if (string.IsNullOrWhiteSpace(Apellido)) 
            throw new ArgumentException("Un personaje no puede nacer sin Apellido.");

        if (fecha_nacimiento > DateTime.Now)
            throw new ArgumentException("No puede haber nacido en el futuro.");
        IdPersonaje = ++ultimoId;
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.fecha_nacimiento = fecha_nacimiento;
        this.Genero = Genero;
        this.TipoRaza = tipo_raza;
    }

    public Personaje()
    {
        IdPersonaje = ++ultimoId;
    }
    
    public void CambiarNombre(string nuevoNombre)
    {
        if (string.IsNullOrWhiteSpace(nuevoNombre))
        {
            throw new ArgumentException("El nombre no puede estar vacío.");
        }
        Nombre = nuevoNombre;
    }

    public void CambiarApellido(string nuevoApellido)
    {
        if (string.IsNullOrWhiteSpace(nuevoApellido))
        {
            throw new ArgumentException("El nombre no puede estar vacío.");
        }
        Apellido = nuevoApellido;
    }

    public void ModificarGenero(string nuevoGenero)
    {
        Genero = nuevoGenero;
    }

    public void ModificarRaza(string NuevaRaza)
    {
        TipoRaza = NuevaRaza;
    }
    
    
}