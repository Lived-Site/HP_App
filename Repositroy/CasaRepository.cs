namespace Repositroy;
using Domain;
using System.Collections.Generic;
using System.Linq;
public class CasaRepository : RepositoryBase<Casa>
{
    
    private void CargarCasasPorDefecto()
    {
        Casa gryffindor = new Casa("Gryffindor", "Godric Gryffindor", "Nick Casi Decapitado");
        Casa slytherin = new Casa("Slytherin", "Salazar Slytherin", "El Barón Sanguinario");
        Casa hufflepuff = new Casa("Hufflepuff", "Helga Hufflepuff", "El Fraile Gordo");
        Casa ravenclaw = new Casa("Ravenclaw", "Rowena Ravenclaw", "La Dama Gris");
        Agregar(gryffindor);
        Agregar(slytherin);
        Agregar(hufflepuff);
        Agregar(ravenclaw);
    }
    public override Casa? ObtenerPorId(int id)
    {
        IEnumerable<Casa> todasLasCasas = ObtenerTodos();
        return todasLasCasas.FirstOrDefault(c => c.TieneEsteId(id));
    }
    public override bool Existe(int id)
    {
        IEnumerable<Casa> todasLasCasas = ObtenerTodos();
        return todasLasCasas.Any(c => c.TieneEsteId(id));
    }
}