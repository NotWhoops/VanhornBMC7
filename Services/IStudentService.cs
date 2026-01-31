using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITCheckoutAPIv2.Models;

namespace ITCheckoutAPIv2.Services
{
    public interface IStudentService
    {
        Student AddStudent(Student newStudent);
        List<Student> GetStudent();
        Student? GetStudentById(int id);
        Student? UpdateStudent(int id, Student updateStudent);
        bool DeleteStudent(int id);
    }
}