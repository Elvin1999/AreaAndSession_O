using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Linq;
using WebApplication2.Models;

namespace WebApplication2.ViewComponents
{
    public class StudentListViewComponent:ViewComponent
    {
        private SchoolDbContext _context;

        public StudentListViewComponent(SchoolDbContext context)
        {
            _context = context;
        }

        public ViewViewComponentResult Invoke()
        {
            return View(new StudentListViewModel
            {
                Students =
                _context.Students.ToList()
            });
        }
        
    }
}
