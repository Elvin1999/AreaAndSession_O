using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using WebApplication2.Entities;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class EmployeesController : Controller
    {
        private ICalculator _calculator;

        public EmployeesController(ICalculator c1,ICalculator c2)
        {
            _calculator = c1;
            _calculator.Calculate(200);
        }

        [HttpGet]
        public IActionResult Add()
        {
            
            var vm = new EmployeeAddViewModel
            {
                Employee = new Employee(),
                Cities=new List<SelectListItem>
                {
                    new SelectListItem
                    {
                         Text="Baku",Value="10"
                    },
                    new SelectListItem
                    {
                         Text="Xirdalan",Value="01"
                    },
                    new SelectListItem
                    {
                         Text="Sumqayit",Value="50"
                    },
                }
           
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Add(EmployeeAddViewModel vm)
        {
            vm.Cities = new List<SelectListItem>
                {
                    new SelectListItem
                    {
                         Text="Baku",Value="10"
                    },
                    new SelectListItem
                    {
                         Text="Xirdalan",Value="01"
                    },
                    new SelectListItem
                    {
                         Text="Sumqayit",Value="50"
                    },
                };
            if (ModelState.IsValid)
            {

                return View(vm);
            }
            else
            {
                return View(vm);
            }
        }
    }
}
