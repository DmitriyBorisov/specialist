using Lab4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View(Student.All);
        }

        public IActionResult Details(int id)
        {
            Student student = Student.All.Where(s => s.Id == id).SingleOrDefault();
            if (student == null) return NotFound();
            return View(student);
        }
    }
}
