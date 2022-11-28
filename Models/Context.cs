using Microsoft.EntityFrameworkCore;

namespace ACCFlexTask.Models
{
    public class Context :DbContext
    {
        public Context ()
            : base() { }
        public Context(DbContextOptions options):base(options) 
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=StudentCourseTask;Integrated Security=True");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Courses> Courses { get; set; } 
        public DbSet<Gender> Genders { get; set; }
        public DbSet<StudentClass> studentClasses { get; set; }
    }
}
