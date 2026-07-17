namespace Domain;

public class Cuestionario
{
    private static int ultimoId = 0;
    public int IdCuestionario { get; set; }
    public int Dificultad { get; set; }
    public List<Pregunta> Preguntas { get; set; }

    public Cuestionario(List<Pregunta> preguntas)
    {
        if (preguntas == null)
            throw new ArgumentNullException(nameof(preguntas));

        if (preguntas.Count == 0)
            throw new ArgumentException("El cuestionario debe tener al menos una pregunta.");

        IdCuestionario = ultimoId;
        ultimoId++;

        Preguntas = preguntas;
        Dificultad = AsignarDificultad();
    }

    public void AgregarPregunta(Pregunta pregunta)
    {
        if (pregunta == null)
            throw new ArgumentNullException(nameof(pregunta));

        Preguntas.Add(pregunta);
        Dificultad = AsignarDificultad();
    }

    private int AsignarDificultad()
    {
        int suma = 0;

        foreach (Pregunta pregunta in Preguntas)
        {
            suma += pregunta.Dificultad;
        }

        return suma / Preguntas.Count;
    }
}