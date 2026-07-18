namespace Domain;

public class Pregunta
{
    private static int UltimoId = 0;
    public int IdPregunta { get; set; }
    public string Letra { get; set; }
    public int Dificultad { get; set; }
    public List<string> Respuestas { get; set; }
    public string RespuestaCorrecta { get; set; }

    public Pregunta(string letra, int dificultad, List<string> respuestas, string respuestaCorrecta)
    {
        this.IdPregunta = UltimoId;
        UltimoId++;
        if (string.IsNullOrWhiteSpace(letra)) 
            throw new ArgumentException("Debe ingresar una letra");
        if (string.IsNullOrWhiteSpace(respuestaCorrecta))
            throw new ArgumentException("Debe ingresar una respuesta correcta");
        if(Respuestas != null && Respuestas.Count < 2)
            throw new ArgumentException("Debe ingresar al menos 2 respuesta");
        if (dificultad < 1)
            throw new ArgumentException("La dificultad debe ser mayor que 0");
        if (!respuestas.Contains(respuestaCorrecta))
            throw new ArgumentException("La respuesta correcta debe estar entre las opciones.");
        
        this.Letra = letra;
        this.Dificultad = dificultad;
        this.Respuestas = respuestas;
        this.RespuestaCorrecta = respuestaCorrecta;
    }

    public void ModificarPregunta(string nuevaPregunta)
    {
        if (string.IsNullOrWhiteSpace(nuevaPregunta))
            throw new ArgumentException("Debe ingresar una nueva pregunta");
        Letra = nuevaPregunta;
    }

    public void ModificarRespuestaCorrecta(string nuevaRespuestaCorrecta)
    {
        if (string.IsNullOrWhiteSpace(nuevaRespuestaCorrecta))
            throw new ArgumentException("Debe ingresar una respuesta correcta");
        RespuestaCorrecta = nuevaRespuestaCorrecta;
    }

    public void ModificarOpcionesDeRespuestas(List<string> nuevasRespuestas)
    {
        if (nuevasRespuestas.Count < 2)
            throw new ArgumentException("Debe ingresar al menos 2 opciones");

        Respuestas = nuevasRespuestas;
    }

    public void ModificarDificultad(int nuevaDificultad)
    {
        if(nuevaDificultad < 1)
            throw new ArgumentException("La dificultad debe ser mayor que cero");
        Dificultad = nuevaDificultad;
    }
    

    
}