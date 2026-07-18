using Domain;

namespace Repositroy;

public class CuestionarioRepository : RepositoryBase<Cuestionario>
{
    public CuestionarioRepository()
    {
        if (!ObtenerTodos().Any())
        {
            CargarCuestionariosPorDefecto();
        }
    }

    private void CargarCuestionariosPorDefecto()
    {
        List<Pregunta> preguntas = new List<Pregunta>();
        List<string> l1 = new List<string>();
        l1.Add("J.K. Rowling");
        l1.Add("Stephen King");
        l1.Add("Agatha Christie");
        l1.Add("Ninguno de los anteriores");
        Pregunta p1 = new Pregunta("¿Quien es la autora de Harry Potter?", 1, l1, l1[0]);
        preguntas.Add(p1);
        Cuestionario c1 = new Cuestionario(preguntas);
        Agregar(c1);
    }
}