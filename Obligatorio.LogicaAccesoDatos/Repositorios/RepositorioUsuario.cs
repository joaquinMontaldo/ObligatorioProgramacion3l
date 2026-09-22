using Obligatorio.LogicaNegocio.Entidades;
using Obligatorio.LogicaNegocio.IRepositorios;

namespace Obligatorio.LogicaAccesoDatos.Repositorios
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private ApplicationDbContext _context;

        public RepositorioUsuario(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Usuario nuevo)
        {
            _context.Usuarios.Add(nuevo);
            _context.SaveChanges();
        }

        public List<Usuario> FindAll()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario FindById(int id)
        {
            return _context.Usuarios.Where(usuario => usuario.Id.Equals(id)).SingleOrDefault()!;
        }

        public void Remove(Usuario ToEliminar)
        {
            _context.Usuarios.Remove(ToEliminar);
            _context.SaveChanges();
        }

        public void Update(Usuario ToEditar)
        {
            _context.Usuarios.Update(ToEditar);
            _context.SaveChanges();
        }
    }
}
