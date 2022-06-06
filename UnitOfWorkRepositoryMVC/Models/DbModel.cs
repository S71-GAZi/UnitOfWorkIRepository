using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnitOfWorkRepositoryMVC.Models
{
    public enum Gender { Male=1, Female}
    public enum Department { HR = 1, Programmer,Developar }

    public class Employee
    {
        public int EmployeeID { get; set; }
        [Required,StringLength(50)]
        public string EmployeeName { get; set; }
        [Required,StringLength(50)]
        public string Address { get; set; }
        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }
        [Required]
        [EnumDataType(typeof(Department))]
        public Department Department { get; set; }

    }
}