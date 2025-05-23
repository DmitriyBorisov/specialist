using Lab6._2.DAO;
using Lab6._2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab6._2.Controllers
{
    public class StudentController : Controller
    {
        private IStudentDAO studentDAO;

        public StudentController(IStudentDAO studentDAO)
        {
            this.studentDAO = studentDAO;
        }



        // GET: StudentController
        public ActionResult Index()
        {
            return View(studentDAO.Get());
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View(studentDAO.Get(id));
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    studentDAO.Add(student);
                    return RedirectToAction(nameof(Index));
                }
                else 
                {
                    return View(student);
                }
            }
            catch
            {
                ModelState.AddModelError("Insert", "Student inserting error");
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(studentDAO.Get(id));
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    studentDAO.Update(student);
                    return RedirectToAction(nameof(Index));
                }
                else
                { 
                    return View(student);
                }
            }
            catch
            {
                ModelState.AddModelError("Update", "Student updating error");
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(studentDAO.Get(id));
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Student student)
        {
            try
            {
                    studentDAO.Delete(id);
                    return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("Delete", "Student deleting error");
                return View(studentDAO.Get(id));
            }
        }
    }
}
