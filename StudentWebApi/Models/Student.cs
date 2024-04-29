namespace StudentWebApi.Models
{
    public class Student
    {
        public int id { get; set; }
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty ;
        public string email { get; set; } = string.Empty;
        public string dob { get; set; } = string.Empty;
        public int age { get; set; }

        public Student()
        {
            
        }

        public Student(int id, string firstName, string lastName, string email, string dob, int age)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.dob = dob;
            this.age = age;
        }
    }
}
