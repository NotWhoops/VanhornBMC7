using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITCheckoutAPIv2.Models;

namespace ITCheckoutAPIv2.Services
{
    public class StudentService : IStudentService
    {
        private readonly List<Student> _studentList = new();

        public StudentService()
        { 
            _studentList.Add(new Student
            {   
                Id = 1,
                FullName = "Name",
                Email = "Email",
                IsCheckedOut = true
            });
            _studentList.Add(new Student
            {   
                Id = 2,
                FullName = "Name",
                Email = "Email",
                IsCheckedOut = false
            });
        }

        public Student AddStudent(Student newStudent)
        {
            int newId = _studentList.Count == 0 ? 1 : _studentList.Max(d => d.Id) + 1;

            newStudent.Id = newId;

            _studentList.Add(newStudent);
            return newStudent;
        }

        public bool DeleteStudent(int id)
        {
           Student? student = _studentList.FirstOrDefault(d => d.Id == id);

           if( student == null)
            {
                return false;
            }
            _studentList.Remove(student);
            return true;
        }

        public List<Student> GetStudent()
        {
            return _studentList;
        }

        public Student? GetStudentById(int id)
        {
            return _studentList.FirstOrDefault(d => d.Id == id);
        }

        public Student? UpdateStudent(int id, Student updatedStudent)
        {
            Student? existingStudent = _studentList.FirstOrDefault(d => d.Id == id);

            if(existingStudent == null)
            {
                return null;
            }
            existingStudent.FullName = updatedStudent.FullName;
            existingStudent.Email = updatedStudent.Email;
            existingStudent.IsCheckedOut = updatedStudent.IsCheckedOut;
            
            return existingStudent;
        }
    }
}