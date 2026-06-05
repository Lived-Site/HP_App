namespace Domain;

public class Duende : Personaje
{
    private bool trabajaEnGrigots { get; set; }
    private bool habilidadForja { get; set; }

    public Duende(string Nombre, string Apellido, DateTime fecha_nacimiento, string Genero, string tipo_raza, string foto, bool trabajaEnGrigots,
        bool habilidadForja) : base(Nombre, Apellido, fecha_nacimiento, Genero, tipo_raza, foto)
    {
        this.trabajaEnGrigots = trabajaEnGrigots;
        this.habilidadForja = habilidadForja;
    }
}