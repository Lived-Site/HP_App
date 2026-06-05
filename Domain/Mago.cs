namespace Domain;

public class Mago : Personaje
{
    private string TipoSangre { get; set; }
    public int IdCasa { get; set; }
    private List<Hechizo> HechizosConocidos { get; set; }
    private Varita varita { get; set; }
    private List<Mascota> Mascotas { get; set; }

    public Mago()
    {
    }

    public Mago(string nombre,string apellido, DateTime fechaNacimiento, string genero, string tipoRaza, string foto, string tipoSangre, int idCasa) : base(nombre,apellido, fechaNacimiento, genero, tipoRaza, foto)
    {
        TipoSangre = tipoSangre;
        IdCasa = idCasa;
        HechizosConocidos = new List<Hechizo>();
        Mascotas = new List<Mascota>();
    }

    public void AprendeHechizo(Hechizo HechizoNuevo)
    {
        HechizosConocidos.Add(HechizoNuevo);
    }

    public void AsignarVarita(Varita varita)
    {
        this.varita = varita;
    }

    public void AdoptarMascotas(Mascota MascotaNueva)
    {
        Mascotas.Add(MascotaNueva);
    }
}