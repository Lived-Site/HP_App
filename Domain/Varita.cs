namespace Domain;

public class Varita
{
    private static int ultimoId = 0;
    private int IdVarita { get; set; }
    private string Nucleo { get; set; }
    private int Longitud { get; set; }
    private bool esVaritaDeSauco { get; set; }

    public Varita(string Nucleo, int Longitud, bool esVaritaDeSauco)
    {
        IdVarita = ++ultimoId;
        this.Nucleo = Nucleo;
        this.Longitud = Longitud;
        this.esVaritaDeSauco = esVaritaDeSauco;
    }
    
    public Varita(){}
}