namespace Lab3._1
{
    public class Course
    {
        public int Id { get; set; }
        public string Title {  get; set; }
        public int Duration { get; set; }


        public static IList<Course> All = [ 
         new Course(1, "C# 13", 40),
         new Course(2, "Pattern OOP", 24),
         new Course(3, "C# Client-Server", 40),
         new Course(4, "ASP.NET MVC 9", 40),
         new Course(5, "Git", 16)
        ];


        public Course(int id, string title, int duration)
        {
            Id = id;
            Title = title;
            Duration = duration;
        }
    }
}
