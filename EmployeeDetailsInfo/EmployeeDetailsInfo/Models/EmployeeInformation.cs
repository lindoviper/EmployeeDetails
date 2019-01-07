using System;

namespace EmployeeDetailsInfo.Models
{
    public class EmployeeInformation
    {
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public long Phone { get; set; }
        public string WebAddress { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
    }
}
