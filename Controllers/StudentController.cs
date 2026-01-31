using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITCheckoutAPIv2.Models;
using ITCheckoutAPIv2.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITCheckoutAPIv2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }


        [HttpGet("getStudentList")]

        public List<Student> GetStudent()
        {
            return _studentService.GetStudent();
        }



        [HttpGet("AddStudentById/{id}")]


        public Student? GetStudentById(int id)
        {
            return _studentService.GetStudentById(id);
        }



        [HttpPost("AddStudent")]

        public Student AddStudent(Student student)
        {
            return _studentService.AddStudent(student);
        }


        

        [HttpPut("updateStudent/{id}")]

        public Student? UpdateStudent(int id, Student student)
        {
            return _studentService.UpdateStudent(id, student);
        }

        

        [HttpDelete("removeStudent{id}")]
        public bool DeleteStudent(int id)
        {
            return _studentService.DeleteStudent(id);
        }
    }
}