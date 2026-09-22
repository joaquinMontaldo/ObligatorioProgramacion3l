using Obligatorio.LogicaNegocio.Entidades;
using Obligatorio.LogicaNegocio.IRepositorios;

namespace Obligatorio.LogicaAccesoDatos.Repositorios
{
    public class RepositorioFinal : IRepositorioFinal
    {
        private ApplicationDbContext _context;

        public RepositorioFinal(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Final nuevo)
        {
            _context.Finales.Add(nuevo);
            _context.SaveChanges();
        }

        public List<Final> FindAll()
        {
            return _context.Finales.ToList();
        }

        public Final FindById(int id)
        {
            return _context.Finales.Where(capituloFinal => capituloFinal.Id.Equals(id)).SingleOrDefault()!;
        }

        public void Remove(Final ToEliminar)
        {
            _context.Finales.Remove(ToEliminar);
            _context.SaveChanges();
        }

        public void Update(Final ToEditar)
        {
            _context.Finales.Update(ToEditar);
            _context.SaveChanges();
        }
    }
}
