using System;
using System.Collections.Generic;

namespace ACCFlexTask.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public int Diotation { get; set; }
        public virtual ICollection<Teacher> teacher { get; set; }
    }
}
