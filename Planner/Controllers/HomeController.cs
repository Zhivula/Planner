using Planner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Planner.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.List = new List<Day> {
                new Day { Name = "Monday", Tasks = new List<Task>{ new Task(){ Subject = "Английский", Finish = DateTime.Now, Start = DateTime.Now } } },
                new Day { Name = "Tuesday", Tasks = new List<Task>{ new Task(){ Subject = "Испанский", Finish = DateTime.Now, Start = DateTime.Now } } },
                new Day { Name = "Wednesday", Tasks = new List<Task>{ new Task(){ Subject = "Русский", Finish = DateTime.Now, Start = DateTime.Now } } },
                new Day { Name = "Thursday", Tasks = new List<Task>{ new Task(){ Subject = "Китайский", Finish = DateTime.Now, Start = DateTime.Now } } },
                new Day { Name = "Friday", Tasks = new List<Task>{ new Task(){ Subject = "Французский", Finish = DateTime.Now, Start = DateTime.Now } } },
                new Day { Name = "Saturday", Tasks = new List<Task>{ new Task(){ Subject = "Польский", Finish = DateTime.Now, Start = DateTime.Now } } },
                new Day { Name = "Sunday", Tasks = new List<Task>{ new Task(){ Subject = "Японский", Finish = DateTime.Now, Start = DateTime.Now } } },
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}