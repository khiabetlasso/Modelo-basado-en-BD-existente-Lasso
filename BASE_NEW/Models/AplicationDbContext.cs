using Microsoft.EntityFrameworkCore;

namespace BASE_NEW.Models
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Producto> producto { get; set; }
        public DbSet<Detalle> detalle { get; set; }
        public DbSet<Factura> factura { get; set; }

    }
}
