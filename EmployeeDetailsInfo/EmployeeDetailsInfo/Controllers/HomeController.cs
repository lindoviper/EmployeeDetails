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

        public IActionResult AllEmployees()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveEmployeeInformation
        (string title, DateTime dateOfBirth, string firstName,
            string lastName, string gender, string email,
            long phone, string webAddress, string facebook, string instagram, string twitter, string address1, string address2)
        {
            var EmployeeInformation = new EmployeeInformation()
            {
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                Gender = gender,
                Email = email,
                Phone = phone,
                WebAddress = webAddress,
                Facebook = facebook,
                Instagram = instagram,
                Twitter = twitter
            };
            var foo = new EmployeeDataSaver();
            foo.Save(EmployeeInformation);

            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class EmployeeInformation
    {
        public string FirstName { get; internal set; }
        public DateTime DateOfBirth { get; internal set; }
        public string Email { get; internal set; }
        public string LastName { get; internal set; }
        public string Gender { get; internal set; }
        public long Phone { get; internal set; }
        public string WebAddress { get; internal set; }
        public string Facebook { get; internal set; }
        public string Instagram { get; internal set; }
        public string Twitter { get; internal set; }
    }
}
