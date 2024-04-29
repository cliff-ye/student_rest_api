using Microsoft.EntityFrameworkCore;
using StudentWebApi.Data;
using StudentWebApi.Dto;
using StudentWebApi.Models;

namespace StudentWebApi.Services.StudentService
{
    public class StudentServiceDb : IStudentService
    {
        private readonly AppDbContext _appDbContext;
        public StudentServiceDb(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;   
        }
        public Student Add(StudentDto studentDto)
        {
            var student = CustomMapper.Mapper.MapDtoToStudent(studentDto);
             _appDbContext.Students.Add(student);
            _appDbContext.SaveChanges();

            return student;
        }

        public void Delete(int id)
        {
            var student = _appDbContext.Students.Find(id);
           
            _appDbContext.Students.Remove(student);
        }

        public Student Get(int id)
        {
            var student = _appDbContext.Students.Find(id);
            return student;
        }

        public IEnumerable<Student> GetAllStudents()
        {
           var students = _appDbContext.Students.ToList();
            return students;
        }

        public void Update(int id, StudentDto studentDto)
        {
            var student = _appDbContext.Students.Find(id);

            student.firstName = studentDto.FirstName;
            student.lastName = studentDto.LastName; 
            student.email = studentDto.Email;
            student.dob = studentDto.BirthDate;
            student.age = studentDto.Age;

            _appDbContext.SaveChanges();
        }
    }
}
