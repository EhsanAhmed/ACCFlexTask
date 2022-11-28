using ACCFlexTask.Models;
using System.Collections.Generic;
using System.Linq;

namespace ACCFlexTask.Repository
{
    public class CourseRepository:ICourseRepository
    {
        private readonly Context context;
        public CourseRepository(Context _context)
        {
            context = _context;
        }
        public List<Courses> GetAll()
        {
            return context.Courses.ToList();
        }

        public Courses GetById(int id)
        {
            return context.Courses.FirstOrDefault(C => C.Id == id);
        }

        public int Insert(Courses course)
        {
            context.Courses.Add(course);
            return context.SaveChanges();
        }

        public int Update(int id, Courses course)
        {
            Courses oldcourse = GetById(id);
            if (oldcourse != null)
            {
                oldcourse.Name = course.Name;

                return context.SaveChanges();
            }
            return 0;
        }

        public int Delete(int id)
        {

            Courses oldcourse = GetById(id);
            context.Courses.Remove(oldcourse);
            return context.SaveChanges();
        }

    }
}
