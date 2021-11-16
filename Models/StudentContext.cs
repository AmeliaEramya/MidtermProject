using System.Data.Entity;

namespace MidtermProject.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
