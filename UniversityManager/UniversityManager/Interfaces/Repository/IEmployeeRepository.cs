using System.Collections.Generic;
using UniversityManager.Models;

namespace UniversityManager.Interfaces.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
    }
}
