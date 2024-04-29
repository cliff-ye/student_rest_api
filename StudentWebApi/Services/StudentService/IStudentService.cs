using Microsoft.AspNetCore.Mvc;
using StudentWebApi.Dto;
using StudentWebApi.Models;

namespace StudentWebApi.Services.StudentService
{
    public interface IStudentService
    {
        public IEnumerable<Student> GetAllStudents();
        public Student Add(StudentDto studentDto);
        public void Delete(int id);
        public void Update(int id, StudentDto studentDto);
        public Student Get(int id);
    }
}
