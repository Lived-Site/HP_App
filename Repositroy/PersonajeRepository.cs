namespace Repositroy;
using Domain;

public class PersonajeRepository : RepositoryBase<Personaje>
{
    public override Personaje? ObtenerPorId(int id)
    {
        return _elementos.FirstOrDefault(p => p.IdPersonaje == id);
    }

    public override bool Existe(int id)
    {
        return _elementos.Any(p => p.IdPersonaje == id);
    }

    public void Editar(int idAEditar, string NuevoNombre,string NuevoApellido, string NuevoGenero, string nuevaRaza)
    {
        var personajeActual = ObtenerPorId(idAEditar);
        
        if (personajeActual != null)
        {
            personajeActual.CambiarNombre(NuevoNombre);
            personajeActual.CambiarApellido(NuevoApellido);
            personajeActual.ModificarGenero(NuevoGenero);
            personajeActual.ModificarRaza(nuevaRaza);
        }
    }
}