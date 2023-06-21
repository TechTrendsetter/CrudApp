using System.Data.Entity;

namespace Abdullah.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}