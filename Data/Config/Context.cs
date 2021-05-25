using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ContextApp : DbContext
    {
        public ContextApp(DbContextOptions<ContextApp> options) : base(options) { }
        public DbSet<Emissora> Emissoras { get; set; }
        public DbSet<Audiencia> Audiencias { get; set; }
    }
}
