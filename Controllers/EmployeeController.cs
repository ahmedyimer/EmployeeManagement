using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Model;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {

            EmployeeRepository employeeRepository = new EmployeeRepository();
            Employee employee = employeeRepository.GetEmployee(1);

            return View(employee);
        }
    }
}