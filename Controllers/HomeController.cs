using Administration.Models;
using Administration.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Administration.Controllers
{
    // [Route("[controller]")]
    public class HomeController : Controller
    {
        private iEmployeeRepository _employeeRepository;

        public HomeController(iEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        //   [Route("")]
        //   [Route("[action]")]
        //   [Route("~/")]
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployees();
            return View(model);
        }

        //   [Route("[action]/{id?}")]
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id ?? 1),
                PageTitle = "Employee Details"

            };

            return View(homeDetailsViewModel);
        }
        [HttpGet]
        public ViewResult  Create()
        {

            return View();

        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee newEmployee = _employeeRepository.Add(employee);
                return RedirectToAction("details", new { id = newEmployee.Id });
            }

            return View();
        }
    }
}
