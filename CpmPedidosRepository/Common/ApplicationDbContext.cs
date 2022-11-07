using CpmPedidosDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CpmPedidosRepository.Common
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Customers { get; set; }
        public DbSet<CategoryProduct> CategoriesProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PromotionProduct> PromotionsProducts { get; set; }
        public DbSet<Combo> Combos { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestProduct> RequestsProducts { get; set; }

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