using System.Collections.Generic;

namespace ACCFlexTask.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Courses> courses { get; set; }
        public virtual ICollection<Student> students { get; set; }  
    }
}
