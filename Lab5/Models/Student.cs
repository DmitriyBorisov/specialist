using System.ComponentModel.DataAnnotations;
using Lab5.Attributes;

namespace Lab5.Models
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 32, MinimumLength = 3, ErrorMessage = "Name should have at least 3 characters")]
        [RegularExpression(pattern: "^[A-Za-z]+$", ErrorMessage = "Name should have letters only")]
        public string Name { get; set; }
        [Range(18, 120, ErrorMessage = "Age should be between 18 and 120")]
        public int? Age { get; set; }
        [Address(ErrorMessage = "Adress should have City,Street,House")]
        public string Address { get; set; }


        public static IList<Student> All = [
         new Student(1, "Ivan", 18, "Moscow,Lenina,3"),
         new Student(2, "John", 19, "Krasnodar,Zelyonaya,10"),
         new Student(3, "Ben", 23, "Orel,Michurina,56"),
         new Student(4, "Antony", 20, "Kerch,Komsomolskaya,35"),
         new Student(5, "Alex", 27, "Abakan,Gagarina,5")
        ];

        public Student() { }

        public Student(int id, string name, int age, string address)
        {
            Id = id;
            Name = name;
            Age = age;
            Address = address;
        }
    }
}
