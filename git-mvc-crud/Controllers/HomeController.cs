using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using git_mvc_crud.Models;

namespace git_mvc_crud.Controllers
{
    public class HomeController : Controller
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee {EmployeeID= 1 , EmployeeName="Arwa"},
            new Employee {EmployeeID= 2 , EmployeeName="Rawabe"},
            new Employee {EmployeeID= 3 , EmployeeName="Amal"}
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            ViewData["Employees"] = employees;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
