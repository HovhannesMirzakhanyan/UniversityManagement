using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagment.Models;

namespace UniversityManagment.Services
{
    public class UniversityService
    {
        private Student _student;
        private Teacher _teacher;
        private StudentService _studentService;
        private TeacherService _teacherService;
        public UniversityService(Student student, Teacher teacher)
        {
            _student = student;
            _teacher = teacher;
        }
        public UniversityService(StudentService studentService, TeacherService teacherService)
        {
            _teacherService = teacherService;
            _studentService = studentService;
        }

        public void AddTeacher(Student student, Teacher teacher)
        {
            student._teacher = teacher;
        }

    }
}
