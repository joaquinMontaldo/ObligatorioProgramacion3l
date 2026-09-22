using Obligatorio.LogicaNegocio.Entidades;
using Obligatorio.LogicaNegocio.IRepositorios;

namespace Obligatorio.LogicaAccesoDatos.Repositorios
{
    public class RepositorioLectura : IRepositorioLectura
    {
        private ApplicationDbContext _context;

        public RepositorioLectura(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Lectura nuevo)
        {
            _context.Lecturas.Add(nuevo);
            _context.SaveChanges();
        }

        public List<Lectura> FindAll()
        {
            return _context.Lecturas.ToList();
        }

        public Lectura FindById(int id)
        {
            return _context.Lecturas.Where(lectura => lectura.Id.Equals(id)).SingleOrDefault()!;
        }

        public void Remove(Lectura ToEliminar)
        {
            _context.Lecturas.Remove(ToEliminar);
            _context.SaveChanges();
        }

        public void Update(Lectura ToEditar)
        {
            _context.Lecturas.Update(ToEditar);
            _context.SaveChanges();
        }
    }
}
