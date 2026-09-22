namespace Obligatorio.LogicaNegocio.IRepositorios
{
    public interface IRepositorio<T> where T : class
    {
        void Add(T nuevo);

        List<T> FindAll();

        T FindById(int id);

        void Remove(T toEliminar);

        void Update(T toEditar);
    }
}
