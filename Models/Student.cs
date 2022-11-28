using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACCFlexTask.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        [ForeignKey("Gender")]
        public int GenderID { get; set; }
        public virtual Gender Gender { get; set; }
        [ForeignKey("Class")]
        public int ClassID { get; set; }
        public virtual StudentClass Class { get; set; } 
        public virtual ICollection<Courses> courses { get; set; }= new List<Courses>();
    }
}
