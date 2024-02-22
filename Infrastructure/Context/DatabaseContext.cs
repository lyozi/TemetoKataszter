using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace Infrastructure.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }

        public DbSet<Grave> GraveItems { get; set; } = null!;
    }
}
