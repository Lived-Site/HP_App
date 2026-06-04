namespace Domain;

public class Muggle : Personaje
{
    private string Profesion { get; set; }
    private bool SabeDeMagia { get; set; }

    public Muggle(string nombre,string apellido, DateTime fechaNacimiento, string genero, string tipoRaza, string Profesion,
        bool SabeDeMagia) : base(nombre, apellido, fechaNacimiento, genero, tipoRaza)
    {
        this.Profesion = Profesion;
        this.SabeDeMagia = SabeDeMagia;
    }
    public Muggle(){}
}