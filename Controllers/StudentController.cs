using ACCFlexTask.Models;
using ACCFlexTask.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ACCFlexTask.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly ICourseRepository courseRepository;
        private readonly ITeacherRepository eacherRepository;
        private readonly IGender genderRepository;
        private readonly IStudentClass studentClassRepository;
        
      public StudentController(IStudentRepository _studentRepository,
            ICourseRepository _courseRepository,
            ITeacherRepository _eacherRepository,
            IGender _genderRepository,
            IStudentClass _studentClassRepository
            )
        {
            this.studentRepository = _studentRepository;
            this.courseRepository = _courseRepository;
            this.eacherRepository = _eacherRepository;
            this.genderRepository = _genderRepository;
            this.studentClassRepository = _studentClassRepository;  
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddStudent()
        {
            Student student = new Student();
            
            List<Courses> courseList = courseRepository.GetAll();
            ViewData["Courses"] = courseList;
            List<Teacher> TeacherList = eacherRepository.GetAll();
            ViewData["Teacher"] = TeacherList;
            List<StudentClass> ClassesList = studentClassRepository.GetAll();
            ViewData["Classes"] = ClassesList;
            List<Gender> GenderList = genderRepository.GetAll();
            ViewData["Gender"] = GenderList;
            return View(student);
           
        }
        public IActionResult SaveStudent(Student student)
        {
            if(student != null)
            {
                studentRepository.Insert(student);
            }
            List<Student> students = studentRepository.GetAll();
            return View("Index", students);
        }
    }
}
