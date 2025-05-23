using Lab6._2.Models;

namespace Lab6._2.DAO
{
    public interface IStudentDAO
    {
        IEnumerable<Student> Get();
        Student Get(int id);
        Student Add(Student student);
        Student Update(Student student);
        void Delete(int id);
    }
}
