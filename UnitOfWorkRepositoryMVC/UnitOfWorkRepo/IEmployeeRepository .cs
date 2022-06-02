using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkRepositoryMVC.Models;

namespace UnitOfWorkRepositoryMVC.UnitOfWorkRepo
{
   public interface IEmployeeRepository:IGenericRepository<Employee>
    {

        IEnumerable<Employee> GetEmployeesByGender(Gender Gender);
        IEnumerable<Employee> GetEmployeesByDepartment(Department Department);
    }
}
