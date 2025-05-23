using Lab5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab5.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            return View(Student.All);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            try
            {
                if (this.ModelState.IsValid)
                {
                    Student.All.Add(student);
                    return RedirectToAction(nameof(Index));
                }
                else
                { 
                    return View(student);
                }
            }
            catch
            {
                return View();
            }
        }

    }
}
