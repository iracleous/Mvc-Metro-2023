using Microsoft.EntityFrameworkCore;

namespace Mvc_Metro_2023.Models
{
    public class MetroDbContext:DbContext
    {
        private readonly string _connectionString = "Data Source=localhost;Initial Catalog=metro-2023;User Id=sa; Password=passw0rd;TrustServerCertificate=True; ";

        public DbSet<Person>? Persons { get; set; }
        public DbSet<Category>? Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

    }
}
