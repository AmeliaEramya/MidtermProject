using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MidtermProject.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("name=SchoolContext")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
    }
}
