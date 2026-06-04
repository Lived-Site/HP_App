namespace Domain;

public class Casa
{
    private static int ultimoId = 0;

    private int Idcasa { get; set; }
    private string Nombre { get; set; }
    private string Fundador { get; set; }
    private string Fantasma { get; set; }


    public Casa(string Nombre, string Fundador, string Fantasma)
    {
        Idcasa = ++ultimoId;
        this.Nombre = Nombre;
        this.Fundador = Fundador;
        this.Fantasma = Fantasma;
    }
    public bool TieneEsteId(int idABuscar)
    {
        return this.Idcasa == idABuscar;
    }
}