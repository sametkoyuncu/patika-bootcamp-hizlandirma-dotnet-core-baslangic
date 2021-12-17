using Microsoft.EntityFrameworkCore;
using linq_practices.Entities;

namespace linq_practices.DBOperations
{
    public class LinqDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "LinqDatabase");
        }
    }
}