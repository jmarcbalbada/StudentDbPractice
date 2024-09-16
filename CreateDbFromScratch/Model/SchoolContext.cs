using Microsoft.EntityFrameworkCore;

namespace CreateDbFromScratch.Model
{
    public class SchoolContext : DbContext
    {
        // create table
        public DbSet<Student> Students { get; set; }

        public SchoolContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
