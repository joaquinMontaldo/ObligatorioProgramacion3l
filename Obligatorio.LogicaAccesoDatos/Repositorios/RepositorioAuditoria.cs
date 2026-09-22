using Obligatorio.LogicaNegocio.Entidades;
using Obligatorio.LogicaNegocio.IRepositorios;

namespace Obligatorio.LogicaAccesoDatos.Repositorios
{
    public class RepositorioAuditoria : IRepositorioAuditoria
    {
        private ApplicationDbContext _context;

        public RepositorioAuditoria(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Auditoria nuevo)
        {
            _context.Auditorias.Add(nuevo);
            _context.SaveChanges();
        }

        public List<Auditoria> FindAll()
        {
            return _context.Auditorias.ToList();
        }

        public Auditoria FindById(int id)
        {
            return _context.Auditorias.Where(auditoria => auditoria.Id.Equals(id)).SingleOrDefault()!;
        }

        public void Remove(Auditoria ToEliminar)
        {
            _context.Auditorias.Remove(ToEliminar);
            _context.SaveChanges();
        }

        public void Update(Auditoria ToEditar)
        {
            _context.Auditorias.Update(ToEditar);
            _context.SaveChanges();
        }
    }
}
