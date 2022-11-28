using System.Collections.Generic;

namespace ACCFlexTask.Models
{
    public class Gender
    {
        public int Id { get; set; }
        public string GenderKind { get; set; }

        public virtual ICollection<Student> Students { get; set; }

    }
}
