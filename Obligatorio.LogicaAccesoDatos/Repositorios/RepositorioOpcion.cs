using Obligatorio.LogicaNegocio.Entidades;
using Obligatorio.LogicaNegocio.IRepositorios;

namespace Obligatorio.LogicaAccesoDatos.Repositorios
{
    public class RepositorioOpcion : IRepositorioOpcion
    {
        private ApplicationDbContext _context;

        public RepositorioOpcion(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Opcion nuevo)
        {
            _context.Opciones.Add(nuevo);
            _context.SaveChanges();
        }

        public List<Opcion> FindAll()
        {
            return _context.Opciones.ToList();
        }

        public Opcion FindById(int id)
        {
            return _context.Opciones.Where(opcion => opcion.Id.Equals(id)).SingleOrDefault()!;
        }

        public void Remove(Opcion ToEliminar)
        {
            _context.Opciones.Remove(ToEliminar);
            _context.SaveChanges();
        }

        public void Update(Opcion ToEditar)
        {
            _context.Opciones.Update(ToEditar);
            _context.SaveChanges();
        }
    }
}
