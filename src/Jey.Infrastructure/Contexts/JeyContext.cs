using Jey.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Jey.Infrastructure.Contexts
{
    public class JeyContext : DbContext
    {

        public JeyContext() { }

        public JeyContext(DbContextOptions<JeyContext> options) : base(options)
        {

        }


        public DbSet<User> User { get; set; }
        public DbSet<Announcements> Announcements { get; set; }
        public DbSet<Guild> Guilds { get; set; }
        public DbSet<SalesHistory> SalesHistory { get; set; }
        public DbSet<Item> items { get; set; }


        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<SalesHistory>().HasNoKey();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={Path.Combine(Directory.GetCurrentDirectory(), "dbbot.db")}");
        }
    }
}