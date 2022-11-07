using CpmPedidosApplication;
using CpmPedidosRepository.Common;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Data.Common;

namespace CpmPedidos.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public DbConnection DbConnection => new NpgsqlConnection(Configuration.GetConnectionString("App"));

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(
                    DbConnection,
                    assembly => assembly.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });

            DependencyInjection.Register(services);

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}