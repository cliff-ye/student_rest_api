using StudentWebApi.Dto;
using StudentWebApi.Models;

namespace StudentWebApi.CustomMapper
{
    public class Mapper
    {
        public static Student MapDtoToStudent(StudentDto studentDto)
        {
            return new Student()
            {
                firstName = studentDto.FirstName,
                lastName = studentDto.LastName,
                email = studentDto.Email,
                dob = studentDto.BirthDate,
                age = studentDto.Age,
            };

        }
    }
}
