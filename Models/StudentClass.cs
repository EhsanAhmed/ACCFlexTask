using System.Collections.Generic;

namespace ACCFlexTask.Models
{
    public class StudentClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }

    }
}
