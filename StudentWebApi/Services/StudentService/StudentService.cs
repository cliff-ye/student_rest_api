using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentWebApi.Dto;
using StudentWebApi.Models;

namespace StudentWebApi.Services.StudentService
{
    public class StudentService : IStudentService
    {
        private static int studentId = 0;

        private static readonly List<Student> students = new List<Student>
        {
            new Student(++studentId, "John","Doe","johndoe@gmail.com",DateTime.Now.AddYears(-26).ToShortDateString(),26),
            new Student(++studentId, "Michael","Stein","ms00@gmail.com",DateTime.Now.AddYears(-32).ToShortDateString(),32),
            new Student(++studentId, "George","Walker","georgewalker@gmail.com",DateTime.Now.AddYears(-26).ToShortDateString(),26),
            new Student(++studentId, "Walker","Smith","walkersmith@gmail.com",DateTime.Now.AddYears(-32).ToShortDateString(),32),

        };
        
        public IEnumerable<Student> GetAllStudents()
        {

            if (students == null)
            {
                return null;
            }
            //logger.LogInformation("getting all employees");
            return students;
        }

        public Student Add(StudentDto studentDto)
        {
            students.Add(new Student(++studentId, studentDto.FirstName, studentDto.LastName, studentDto.Email, studentDto.BirthDate,studentDto.Age));
            return students.Last();
        }

        public void Delete(int id)
        {
            var student = findStudent(id);
            students.Remove(student);
        }

        public void Update(int id, StudentDto studentDto)
        {
            var student = findStudent(id);

            student.firstName = studentDto.FirstName;
            student.lastName = studentDto.LastName;
            student.email = studentDto.Email;
            student.dob = studentDto.BirthDate;
            student.age = studentDto.Age;
        }

       

        private Student findStudent(int id)
        {
            return students.FirstOrDefault(std => std.id == id);
        }

        public Student Get(int id)
        {
            return findStudent(id);
        }
    }
}
