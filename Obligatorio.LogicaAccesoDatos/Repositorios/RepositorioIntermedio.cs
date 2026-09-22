using Obligatorio.LogicaNegocio.Entidades;
using Obligatorio.LogicaNegocio.IRepositorios;

namespace Obligatorio.LogicaAccesoDatos.Repositorios
{
    public class RepositorioIntermedio : IRepositorioIntermedio
    {
        private ApplicationDbContext _context;

        public RepositorioIntermedio(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Intermedio nuevo)
        {
            _context.Intermedios.Add(nuevo);
            _context.SaveChanges();
        }

        public List<Intermedio> FindAll()
        {
            return _context.Intermedios.ToList();
        }

        public Intermedio FindById(int id)
        {
            return _context.Intermedios.Where(intermedio => intermedio.Id.Equals(id)).SingleOrDefault()!;
        }

        public void Remove(Intermedio ToEliminar)
        {
            _context.Intermedios.Remove(ToEliminar);
            _context.SaveChanges();
        }

        public void Update(Intermedio ToEditar)
        {
            _context.Intermedios.Update(ToEditar);
            _context.SaveChanges();
        }
    }
}
