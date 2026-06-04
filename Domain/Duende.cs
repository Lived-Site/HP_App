namespace Domain;

public class Duende : Personaje
{
    private bool trabajaEnGrigots { get; set; }
    private bool habilidadForja { get; set; }

    public Duende(string Nombre, DateTime fecha_nacimiento, string Genero, string tipo_raza, bool trabajaEnGrigots,
        bool habilidadForja) : base(Nombre, fecha_nacimiento, Genero, tipo_raza)
    {
        this.trabajaEnGrigots = trabajaEnGrigots;
        this.habilidadForja = habilidadForja;
    }
}