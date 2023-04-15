using Microsoft.EntityFrameworkCore;
using WebApplication2.Entities;

namespace WebApplication2.Models
{
    public class SchoolDbContext:DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> contextOptions)
            :base(contextOptions)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
