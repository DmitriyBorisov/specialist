using Lab6._2.Models;

namespace Lab6._2.DAO
{
    public class StudentDAOInMemory : IStudentDAO
    {
        private IList<Student> All = [
            new Student(1, "Ivan", 18, "Moscow,Lenina,3"),
            new Student(2, "John", 19, "Krasnodar,Zelyonaya,10"),
            new Student(3, "Ben", 23, "Orel,Michurina,56"),
            new Student(4, "Antony", 20, "Kerch,Komsomolskaya,35"),
            new Student(5, "Alex", 27, "Abakan,Gagarina,5")
        ];
        public Student Add(Student student)
        {
            student.Id = All.Select(x => x.Id).Max() + 1;
            All.Add(student);
            return student;
        }

        public void Delete(int id)
        {
            All.Remove(Get(id));
        }

        public IEnumerable<Student> Get()
        {
            return All;
        }

        public Student Get(int id)
        {
            return All.Where(s => s.Id == id).SingleOrDefault();
        }

        public Student Update(Student newStudent)
        {
            Student student = Get(newStudent.Id);
            if (newStudent != null)
            {
                student.Id = newStudent.Id;
                student.Name = newStudent.Name;
                student.Age = newStudent.Age;
                student.Address = newStudent.Address;
            }
            else throw new Exception($"Student by ID {newStudent.Id} not found");
            return student;
        }
    }
}
