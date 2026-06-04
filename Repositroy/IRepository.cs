namespace Repositroy;

public interface IRepository<T> where T : class
{
    void Agregar(T entidad);
    IEnumerable<T> ObtenerTodos();
    T? ObtenerPorId(int id);
    bool Existe(int id);
    void Eliminar(T entidad);
}