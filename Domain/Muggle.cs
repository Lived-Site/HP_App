namespace Domain;

public class Muggle : Personaje
{
    private string Profesion { get; set; }
    private bool SabeDeMagia { get; set; }

    public Muggle(string nombre, DateTime fechaNacimiento, string genero, string tipoRaza, string Profesion,
        bool SabeDeMagia) : base(nombre, fechaNacimiento, genero, tipoRaza)
    {
        this.Profesion = Profesion;
        this.SabeDeMagia = SabeDeMagia;
    }
    public Muggle(){}
}