using Microsoft.EntityFrameworkCore;
using Obligatorio.LogicaNegocio.Entidades;

namespace Obligatorio.LogicaAccesoDatos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; } = null!;
        public DbSet<Categoria> Categorias { get; set; } = null!;
        public DbSet<Historia> Historias { get; set; } = null!;
        public DbSet<Capitulo> Capitulos { get; set; } = null!;
        public DbSet<Intermedio> Intermedios { get; set; } = null!;
        public DbSet<Final> Finales { get; set; } = null!;
        public DbSet<Opcion> Opciones { get; set; } = null!;
        public DbSet<Lectura> Lecturas { get; set; } = null!;
        public DbSet<Auditoria> Auditorias { get; set; } = null!;
    }
}
