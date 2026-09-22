using Obligatorio.LogicaNegocio.Entidades;
using Obligatorio.LogicaNegocio.IRepositorios;

namespace Obligatorio.LogicaAccesoDatos.Repositorios
{
    public class RepositorioHistoria : IRepositorioHistoria
    {
        private ApplicationDbContext _context;

        public RepositorioHistoria(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Historia nuevo)
        {
            _context.Historias.Add(nuevo);
            _context.SaveChanges();
        }

        public List<Historia> FindAll()
        {
            return _context.Historias.ToList();
        }

        public Historia FindById(int id)
        {
            return _context.Historias.Where(historia => historia.Id.Equals(id)).SingleOrDefault()!;
        }

        public void Remove(Historia ToEliminar)
        {
            _context.Historias.Remove(ToEliminar);
            _context.SaveChanges();
        }

        public void Update(Historia ToEditar)
        {
            _context.Historias.Update(ToEditar);
            _context.SaveChanges();
        }
    }
}
