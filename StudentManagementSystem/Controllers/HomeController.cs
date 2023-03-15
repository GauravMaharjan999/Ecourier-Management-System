using StudentManagement.Models;
using StudentManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modellayer.Models;

namespace StudentManagement.Controllers
{

    public class HomeController : Controller

    {
        private IEmployeeRepositary _employeeRepositary;
        private IEmployeeRepositary _er;
        public HomeController(IEmployeeRepositary employeeRepositary)
        {
            _employeeRepositary = employeeRepositary;
        }
                        
        public ViewResult Index()
        {
            TempData["name"] = "Bill";
            var model = _employeeRepositary.GetAllEmployees();
            var mod = _employeeRepositary.GetAllEmployees();

            ViewBag.list = mod;

            return View(model);

        }

        public ViewResult Details(int? id)
        {
            Employee model = _employeeRepositary.GetEmployee(id ?? 1);
            EmployeeViewModel homeDetailsViewModel = new EmployeeViewModel()
            {
                Employee = model,
                PageTitle = "Employee Details"
            };

            return View(homeDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
           

            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {

            if (ModelState.IsValid)
            {
                Employee newEmployee = _employeeRepositary.Add(employee);
                return RedirectToAction("Index");
            }
            return View();
        }



        [HttpGet]
        public IActionResult Edit(int id)
        {

            //ViewBag.name = TempData["name"].ToString();

            ViewBag.list = TempData["model"];
            Employee employee = _employeeRepositary.GetEmployee(id);
            EmployeeViewModel employeeEditViewModel = new EmployeeViewModel()
            {
                Id = employee.Id,
                Name = employee.Name,
                Email = employee.Email,
                Department = employee.Department



            };
            return View(employeeEditViewModel);
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee newEmployee = _employeeRepositary.Update(employee);
            }
            return RedirectToAction("Index");

        }


        [HttpGet]
        public IActionResult Delete(int id)
        {

            Employee employee = _employeeRepositary.GetEmployee(id);
            EmployeeViewModel employeeViewModel = new EmployeeViewModel()
            {
                Id = employee.Id,
                Name = employee.Name,
                Email = employee.Email,
                Department = employee.Department

            };

            ViewBag.NewEmployee = employeeViewModel;
            return View(employeeViewModel);

        }

        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee newEmployee = _employeeRepositary.Delete(employee.Id);
            }
            return RedirectToAction("Index");
        }



        public IActionResult Viewbag()
        {

            //List<string> TempDataTest = new List<string>();
            //TempDataTest.Add("TempData 1");
            //TempDataTest.Add("TempData 2");
            //TempData["NewEmployee2"] = TempDataTest;


            return View("Index1");
        }

        //public IActionResult about()
        //{

        //    //List<string> modelData = TempData["NewEmployee2"] as List<string>;

        //    ViewBag.name = TempData["name"].ToString();

        //    return View("");
        //}

    }
}
