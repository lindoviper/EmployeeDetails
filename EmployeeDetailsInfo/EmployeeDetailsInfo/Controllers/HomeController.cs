using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeDetailsInfo.Models;
using Newtonsoft.Json;

namespace EmployeeDetailsInfo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewEmployee()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AllEmployees()
        {
            var employeeDataSaver = new EmployeeDataSaver();
            var allEmployees = employeeDataSaver.GetEmployeeInformation();

            return View(allEmployees);
        }

        [HttpPost]
        public IActionResult SaveEmployeeInformation
        (string title, DateTime dateOfBirth, string firstName,
            string lastName, string gender, string email,
            long phone, string webAddress, string facebook, string instagram, string twitter, string address1, string address2)
        {
            var EmployeeInformation = new EmployeeInformation()
            {
                EmployeeId = new Guid(),
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                Gender = gender,
                Email = email,
                Phone = phone,
                WebAddress = webAddress,
                Facebook = facebook,
                Instagram = instagram,
                Twitter = twitter,
                Address1 = address1,
                Address2 = address2
            };
            var employeeDataSaver = new EmployeeDataSaver();
            employeeDataSaver.Save(EmployeeInformation);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateEmployeeInformation
(string title, DateTime dateOfBirth, string firstName,
    string lastName, string gender, string email,
    long phone, string webAddress, string facebook, string instagram, string twitter, string address1, string address2)
        {
            var EmployeeInformation = new EmployeeInformation()
            {
                EmployeeId = new Guid(),
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                Gender = gender,
                Email = email,
                Phone = phone,
                WebAddress = webAddress,
                Facebook = facebook,
                Instagram = instagram,
                Twitter = twitter,
                Address1 = address1,
                Address2 = address2
            };
            var employeeDataSaver = new EmployeeDataSaver();
            var allEmployees = employeeDataSaver.GetEmployeeInformation();

            employeeDataSaver.Save(EmployeeInformation);

            return RedirectToAction("Index");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
