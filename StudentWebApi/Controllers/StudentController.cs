using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentWebApi.Dto;
using StudentWebApi.Models;
using StudentWebApi.Services.StudentService;

namespace StudentWebApi.Controllers
{
    [ApiController]
    [Route("/api/students")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAllStudents()
        {
            var students = _studentService.GetAllStudents();

            if (students == null)
            {
                return NotFound("employees not found");
            }
           
            return Ok(students); 
        }

        [HttpPost]
        public ActionResult<Student> AddStudent(StudentDto studentDto)
        {
            if(studentDto == null)
            {
                return BadRequest();
            }

            var student = _studentService.Add(studentDto);

            return Ok(student);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }

            _studentService.Delete(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult Update(int id,StudentDto studentDto) 
        {
            if(id == 0)
            {
                return BadRequest();
            }

            _studentService.Update(id,studentDto);
            return NoContent();
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            return _studentService.Get(id);
        }
    }
}
