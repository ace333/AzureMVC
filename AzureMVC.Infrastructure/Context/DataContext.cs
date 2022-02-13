using AzureMVC.Domain;
using Microsoft.EntityFrameworkCore;

namespace AzureMVC.Infrastructure.Context
{
    public sealed class DataContext : DbContext
    {
        public DataContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Document> Documents { get; set; }
    }
}
