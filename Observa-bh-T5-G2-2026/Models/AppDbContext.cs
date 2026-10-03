using Microsoft.EntityFrameworkCore;


namespace Observa_bh_T5_G2_2026.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Perfil> Perfis { get; set; }

    }
}
