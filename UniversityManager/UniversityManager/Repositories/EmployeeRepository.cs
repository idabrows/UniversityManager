using Database.University;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UniversityManager.Interfaces.Repository;
using UniversityManager.Models;

namespace UniversityManager.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        EntitiesUniversity connection = new EntitiesUniversity();

        public IEnumerable<Employee> GetEmployees()
        {
            List<Employee> employees = connection.Employees.Select(x => new Employee()
            {
                EmployeeId = x.Id,
                FirstName  = x.FirstName,
                LastName   = x.LastName,
                Building   = x.EmployeesInRooms.Select(er => er.Rooms.Building).FirstOrDefault(),          
                RoomNumber = x.EmployeesInRooms.Select(er => er.Rooms.RoomNumber).FirstOrDefault()
        }).ToList();
            return employees;
        }
    }
}