using ApiStudents.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiStudents.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // Ovde se kreira DbSet
        public DbSet<Subject> Subjects { get; set; }
    }
}
