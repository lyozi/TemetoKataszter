using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Context
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=TemetoKataszter;Username=lyozi;Password=jozsika20030101;",
                b => b.MigrationsAssembly("Infrastructure"));

            return new DatabaseContext(optionsBuilder.Options);
        }
    }
}
