using Obligatorio.LogicaNegocio.Entidades;
using Obligatorio.LogicaNegocio.IRepositorios;

namespace Obligatorio.LogicaAccesoDatos.Repositorios
{
    public class RepositorioCategoria : IRepositorioCategoria
    {
        private ApplicationDbContext _context;

        public RepositorioCategoria(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Categoria nuevo)
        {
            _context.Categorias.Add(nuevo);
            _context.SaveChanges();
        }

        public List<Categoria> FindAll()
        {
            return _context.Categorias.ToList();
        }

        public Categoria FindById(int id)
        {
            return _context.Categorias.Where(categoria => categoria.Id.Equals(id)).SingleOrDefault()!;
        }

        public void Remove(Categoria ToEliminar)
        {
            _context.Categorias.Remove(ToEliminar);
            _context.SaveChanges();
        }

        public void Update(Categoria ToEditar)
        {
            _context.Categorias.Update(ToEditar);
            _context.SaveChanges();
        }
    }
}
