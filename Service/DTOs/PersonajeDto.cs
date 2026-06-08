namespace Service.DTOs;

public class PersonajeDto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Tipo { get; set; } = string.Empty;
    public string FotoUrl { get; set; } = string.Empty;
    public int IdCasa { get; set; } = 0;
    public bool PersonajeCreadoPorElUsuario = true;
}