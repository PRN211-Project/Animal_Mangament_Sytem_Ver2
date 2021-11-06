using System.Collections.Generic;
using Animal_Management_System.Dao;
using Animal_Management_System.Models;

namespace Animal_Management_System.Repository.Implementation
{
    public class ImplEmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDao employeeDao;
        public ImplEmployeeRepository()
        {
            employeeDao = new EmployeeDao();
        }


        public List<Employee> GetAllEmployees() => employeeDao.GetAllEmployees();


        public Employee GetEmployeeById(int employeeId) => employeeDao.GetEmployeeById(employeeId);

        public void AddNewEmployee(Employee newEmployee) => employeeDao.AddNewEmployee(newEmployee);

        public void UpdateEmployee(Employee updateEmployee) => employeeDao.UpdateEmployee(updateEmployee);

        public void DeleteEmployee(Employee deletedEmployee) => employeeDao.DeleteEmployee(deletedEmployee);
        public Employee CheckLogin(string username, string password) => employeeDao.CheckLogin(username, password);

        public List<Employee> GetAllEmployeesByAreaId(int areaId) => employeeDao.GetAllEmployeesByAreaId(areaId);

    }
}