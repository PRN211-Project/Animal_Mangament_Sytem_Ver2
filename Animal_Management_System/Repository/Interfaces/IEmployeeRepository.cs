using System.Collections.Generic;
using Animal_Management_System.Models;

namespace Animal_Management_System.Repository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();

        Employee GetEmployeeById(int employeeId);

        void AddNewEmployee(Employee newEmployee);

        void UpdateEmployee(Employee updateEmployee);

        void DeleteEmployee(Employee deletedEmployee);

        Employee CheckLogin(string username, string password);

        List<Employee> GetAllEmployeesByAreaId(int areaId);
    }
}