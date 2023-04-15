using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Entities;
using WebApplication2.ExtentionMethods;

namespace WebApplication2.Controllers
{
    public class SessionDemoController : Controller
    {
        public string Index()
        {
            HttpContext.Session.SetInt32("age", 25);
            HttpContext.Session.SetString("name", "Admin");

            HttpContext.Session.SetObject("user", new Student
            {
                Id = 15,
                Email = "leyla@gmail.com",
                Firstname = "Leyla",
                Lastname = "Mammadova"
            });

            return "Session Created";
        }

        public string GetSessions()
        {
            return $"{HttpContext.Session.GetInt32("age")}" +
                $"{HttpContext.Session.GetString("name")}";
        }

        public JsonResult GetStudent()
        {
            var student = HttpContext.Session.GetObject<Student>("user");
            return Json(student);
        }
    }
}
