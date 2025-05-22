using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab3._2.Models;

namespace Lab3._2.Controllers
{
    public class StudentController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            return View(Student.All);
        }

        [Route("age/{minAge:int}/{maxAge:int}")]
        public ActionResult ByAge(int minAge, int maxAge)
        {
            return View("Index", Student.All.Where(s => s.Age >= minAge && s.Age <= maxAge));
        }

        [Route("search/{search}")]
        public ActionResult Search(string search)
        {
            return View("Index", Student.All.Where(s => s.Name.Contains(search, StringComparison.OrdinalIgnoreCase)));
        }
      
    }
}
