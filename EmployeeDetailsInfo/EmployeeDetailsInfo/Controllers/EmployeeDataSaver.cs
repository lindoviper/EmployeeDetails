using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Reflection;
using System.Collections.Generic;
using EmployeeDetailsInfo.Models;

namespace EmployeeDetailsInfo.Controllers
{
    public class EmployeeDataSaver
    {

        public List<EmployeeInformation> GetEmployeeInformation()
        {
            var execPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string path = Path.Combine(execPath, "EmployeeData.txt");
            var allEmployees = new List<EmployeeInformation>();

            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    var employee = JsonConvert.DeserializeObject<EmployeeInformation>(s);
                    allEmployees.Add(employee);

                }
            }
            return allEmployees;

        }

        public void Save(EmployeeInformation employeeInformation)
        {
            var execPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string path = Path.Combine(execPath, "EmployeeData.txt");

            try
            {

                using (StreamWriter sw = File.AppendText(path))
                {
                    var employeeJsonData = JsonConvert.SerializeObject(employeeInformation);
                    sw.WriteLine(employeeJsonData);

                }

            }

            catch (Exception ex)
            {
                Console.WriteLine($"There was a problem processing data. See inner exception {ex.InnerException}");
            }
        }
    }
}