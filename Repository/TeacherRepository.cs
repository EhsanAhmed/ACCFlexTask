using ACCFlexTask.Models;
using System.Collections.Generic;
using System.Linq;

namespace ACCFlexTask.Repository
{
    public class TeacherRepository: ITeacherRepository
    {
        private readonly Context context;
        public TeacherRepository(Context _context)
        {
            context = _context;
        }
        public List<Teacher> GetAll()
        {
            return context.Teachers.ToList();
        }

        public Teacher GetById(int id)
        {
            return context.Teachers.FirstOrDefault(C => C.Id == id);
        }

        public int Insert(Teacher teacher)
        {
            context.Teachers.Add(teacher);
            return context.SaveChanges();
        }

        public int Update(int id, Teacher teacher)
        {
            Teacher oldteacher = GetById(id);
            if (oldteacher != null)
            {
                oldteacher.Name = teacher.Name;
                
                return context.SaveChanges();
            }
            return 0;
        }

        public int Delete(int id)
        {

            Teacher oldstudent = GetById(id);
            context.Teachers.Remove(oldstudent);
            return context.SaveChanges();
        }

    }
}
