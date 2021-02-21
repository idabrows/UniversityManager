using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManager.Models
{
    public class Employee
    {
        public int EmployeeId    { get; set; }
        public string FirstName  { get; set; }
        public string LastName   { get; set; }
        public string Building   { get; set; }
        public string RoomNumber { get; set; }
    }
}