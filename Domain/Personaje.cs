
namespace Domain;

public abstract class Personaje
{
    private static int ultimoId = 0;
    public int IdPersonaje { get; private set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime fecha_nacimiento { get; set; }
    public string Genero { get; set; }
    public string TipoRaza { get; set; }
    public string Foto { get; set; }

    public Personaje(string Nombre, string Apellido, DateTime fecha_nacimiento, string Genero, string tipo_raza, string foto)
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
        this.Foto = string.IsNullOrWhiteSpace(foto) ? "silueta.png" : foto;
    }

    public Personaje()
    {
        IdPersonaje = ++ultimoId;
        this.Foto = "silueta.png";
    }
    
    public void ModificarFoto(string nuevaFoto)
    {
        if (string.IsNullOrWhiteSpace(nuevaFoto))
        {
            throw new ArgumentException("El nombre del archivo de la foto no puede estar vacío.");
        }
        Foto = nuevaFoto;
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