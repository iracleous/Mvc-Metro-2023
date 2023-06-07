using Microsoft.EntityFrameworkCore;

namespace Mvc_Metro_2023.Models
{
    public class MetroDbContext:DbContext
    {
 
        public DbSet<Person>? Persons { get; set; }
        public DbSet<Category>? Categories { get; set; }

        public MetroDbContext(DbContextOptions<MetroDbContext> options) 
            : base(options)
        { }


    }
}
