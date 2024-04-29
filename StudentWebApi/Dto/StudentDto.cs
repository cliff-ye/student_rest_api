using System.ComponentModel.DataAnnotations;

namespace StudentWebApi.Dto
{
    public record StudentDto([Required] string FirstName, [Required] string LastName, [Required] string Email, string BirthDate, [Required] int Age);
}
