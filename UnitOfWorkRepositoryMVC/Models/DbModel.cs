using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitOfWorkRepositoryMVC.Models
{
    public enum Gender { Male=1, Female}
    public enum Department { HR = 1, Programmer,Developar }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }

    }
}