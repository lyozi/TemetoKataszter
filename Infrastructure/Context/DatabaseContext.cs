using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Context
{
    public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DatabaseContext>(options =>
                options.UseNpgsql("Host=localhost;Port=5432;Database=TemetoKataszter;Username=lyozi;Password=jozsika20030101;"));
        }

        public DbSet<Grave> GraveItems { get; set; } = null!;
    }
}
 