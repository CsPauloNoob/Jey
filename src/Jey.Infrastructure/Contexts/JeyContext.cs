using Jey.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Jey.Infrastructure.Contexts
{
    public class JeyContext : DbContext
    {

        public JeyContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<User> User { get; set; }
        public DbSet<Guild> Guild { get; set; }
        public DbSet<Item> item { get; set; }
        public DbSet<SalesHistory> SalesHistories { get; set; }

    }
}