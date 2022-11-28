using ACCFlexTask.Models;
using System.Collections.Generic;

namespace ACCFlexTask.Repository
{
    public interface IStudentClass
    {
       List<StudentClass> GetAll();
    }
}
