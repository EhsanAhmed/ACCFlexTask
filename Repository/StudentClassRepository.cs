using ACCFlexTask.Models;
using System.Collections.Generic;
using System.Linq;

namespace ACCFlexTask.Repository
{
    public class StudentClassRepository:IStudentClass
    {
        Context context;
        public StudentClassRepository(Context _context)
        {
            context = _context;
        }
        public List<StudentClass> GetAll()
        {
            return context.studentClasses.ToList();
        }
    }
}
