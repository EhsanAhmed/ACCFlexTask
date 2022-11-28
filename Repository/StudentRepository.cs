using ACCFlexTask.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ACCFlexTask.Repository
{
    public class StudentRepository: IStudentRepository
    {
        private readonly Context context;
        public StudentRepository(Context _context)
        {
            context = _context;
        }
        public List<Student> GetAll()
        {
            return context.Students.Include("courses").ToList();
        }

        public Student GetById(int id)
        {
            return context.Students.Include("StudentClass").Include("Gender").FirstOrDefault(C => C.ID == id);
        }

        public int Insert(Student student)
        {
            context.Students.Add(student);
            return context.SaveChanges();
        }

        public int Update(int id, Student student)
        {
            Student oldstudent = GetById(id);
            if (oldstudent != null)
            {
                oldstudent.Name = student.Name;
                oldstudent.Age = student.Age;
                oldstudent.BirthDate = student.BirthDate;
                oldstudent.ClassID = student.ClassID;
                oldstudent.GenderID = student.GenderID;
                return context.SaveChanges();
            }
            return 0;
        }

        public int Delete(int id)
        {

            Student oldstudent = GetById(id);
            context.Students.Remove(oldstudent);
            return context.SaveChanges();
        }

    
    }
}
