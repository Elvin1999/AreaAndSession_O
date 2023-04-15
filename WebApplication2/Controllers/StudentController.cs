using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        private readonly SchoolDbContext _context;

        public StudentController(SchoolDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            return Json(await _context.Students.ToListAsync());
        }
        //public JsonResult Index()
        //{
        //    var data = _context.Students.ToList();
        //    return Json(data);
        //}




    }
}
