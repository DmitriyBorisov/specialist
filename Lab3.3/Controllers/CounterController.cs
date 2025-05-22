using Lab3._3.Filters;
using Lab3._3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab3._3.Controllers
{
    [MyResultFilter]
    public class CounterController : Controller
    {
        // GET: CounterController
        public ActionResult Index()
        {
            return View(RequestCounter.Counters);
        }

    }
}
