using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagment.Models;
using UniversityManagment.Services;


namespace UniversityManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Sahak", 25);
            Student student1 = new Student("Manuk", 25);
            Student student2 = new Student("Jhon", 25);
            Student student3 = new Student("Richard", 25);
            Student student4 = new Student("Micky", 25);
            Teacher teacher = new Teacher("Nune", 55);
            UniversityService uniService = new UniversityService(student, teacher);
            StudentService service = new StudentService();
           
            uniService.AddTeacher(student, teacher);
            uniService.AddTeacher(student1, teacher);
            uniService.AddTeacher(student2, teacher);
            uniService.AddTeacher(student3, teacher);
            uniService.AddTeacher(student4, teacher);
            uniService.AddStudent(student, teacher);
            uniService.AddStudent(student2, teacher);
            uniService.AddStudent(student3, teacher);
            uniService.AddStudent(student4, teacher);
            uniService.AddStudent(student1, teacher);
            service.Add(student);
            service.Add(student1);
            service.Add(student2);
            service.Add(student3);
            service.Add(student4);


        }
    }
}
