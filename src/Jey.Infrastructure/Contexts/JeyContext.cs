using Jey.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Jey.Infrastructure.Contexts
{
    public class JeyContext : DbContext
    {

        public DbSet<User> User { get; set; }
        public DbSet<Guild> Guild { get; set; }
        public DbSet<Item> item { get; set; }
        public DbSet<SalesHistory> SalesHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={Environment.CurrentDirectory}");

    }
}