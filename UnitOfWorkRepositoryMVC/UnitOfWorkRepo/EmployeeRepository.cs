using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnitOfWorkRepositoryMVC.Models;

namespace UnitOfWorkRepositoryMVC.UnitOfWorkRepo
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IUnitOfWorksRepos<EmployeeDBContext> unitOfWorks) : base(unitOfWorks)
        {

        }

        public EmployeeRepository(EmployeeDBContext context)
            : base(context)
        {
        }

        public IEnumerable<Employee> GetEmployeesByDepartment(Department Department)
        {
            return Context.Employees.Where(emp => emp.Department == Department).ToList();
        }

        public IEnumerable<Employee> GetEmployeesByGender(Gender Gender)
        {
                return Context.Employees.Where(emp => emp.Gender == Gender).ToList();
        }
       
    }  
}