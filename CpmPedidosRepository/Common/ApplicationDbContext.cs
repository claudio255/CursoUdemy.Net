using Microsoft.EntityFrameworkCore;

namespace CpmPedidosRepository.Common
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);//Chamando uma herança

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);//Carregando todo mapeamento
        }

        public ApplicationDbContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }
    }
}