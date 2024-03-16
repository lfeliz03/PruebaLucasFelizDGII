using Microsoft.EntityFrameworkCore;

namespace PruebaLucasFelizDGII.Models
{
    public class DGIIDbContext : DbContext
    {
        public DGIIDbContext(DbContextOptions<DGIIDbContext>options):base(options)
        {
            
        }
        public DbSet<Contribuyentes> Contribuyentes { get; set; }
        public DbSet<Comprobantes> Comprobantes { get; set; }
    }
}
