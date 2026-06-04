namespace Repositroy;

public class RepositoryBase<T> : IRepository<T> where T : class 
{
    protected readonly List<T> _elementos = new List<T>();
    public void Agregar(T entidad)
    {
        _elementos.Add(entidad);
    }

    public IEnumerable<T> ObtenerTodos()
    {
        return _elementos; 
    }

    public void Eliminar(T entidad)
    {
        _elementos.Remove(entidad);
    }
    public virtual T? ObtenerPorId(int id) => throw new NotImplementedException();
    public virtual bool Existe(int id) => throw new NotImplementedException();
    
}