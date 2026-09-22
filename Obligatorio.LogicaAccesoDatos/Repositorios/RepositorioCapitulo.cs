using Obligatorio.LogicaNegocio.Entidades;
using Obligatorio.LogicaNegocio.IRepositorios;

namespace Obligatorio.LogicaAccesoDatos.Repositorios
{
    public class RepositorioCapitulo : IRepositorioCapitulo
    {
        private ApplicationDbContext _context;

        public RepositorioCapitulo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Capitulo nuevo)
        {
            _context.Capitulos.Add(nuevo);
            _context.SaveChanges();
        }

        public List<Capitulo> FindAll()
        {
            return _context.Capitulos.ToList();
        }

        public Capitulo FindById(int id)
        {
            return _context.Capitulos.Where(capitulo => capitulo.Id.Equals(id)).SingleOrDefault()!;
        }

        public void Remove(Capitulo ToEliminar)
        {
            _context.Capitulos.Remove(ToEliminar);
            _context.SaveChanges();
        }

        public void Update(Capitulo ToEditar)
        {
            _context.Capitulos.Update(ToEditar);
            _context.SaveChanges();
        }
    }
}
