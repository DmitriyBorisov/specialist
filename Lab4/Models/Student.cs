namespace Lab4.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public static IList<Student> All = [
         new Student(1, "Ivan", 18),
         new Student(2, "John", 19),
         new Student(3, "Ben", 23),
         new Student(4, "Antony", 20),
         new Student(5, "Alex", 17)
        ];

        public Student() { }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
