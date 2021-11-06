using System.Collections.Generic;
using System.Linq;
using Animal_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Animal_Management_System.Dao
{
    public class EmployeeDao
    {
        private Animal_Management_SystemContext _dbContext;

        public List<Employee> GetAllEmployees()
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                List<Employee> employees = _dbContext.Employees.ToList();
                return employees;
            }
        }

        public Employee GetEmployeeById(int employeeId)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                Employee employee = _dbContext.Employees.AsNoTracking().FirstOrDefault(s => s.Id == employeeId);
                return employee;
            }
        }

        public void AddNewEmployee(Employee newEmployee)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                //_dbContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Employee ON");
                _dbContext.Entry(newEmployee).State = EntityState.Added;
                _dbContext.SaveChanges();
                //_dbContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Employee OFF");
            }
        }

        public void UpdateEmployee(Employee updateEmployee)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                _dbContext.Entry(updateEmployee).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
        }

        public void DeleteEmployee(Employee deletedEmployee)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                _dbContext.Entry(deletedEmployee).State = EntityState.Deleted;
                _dbContext.SaveChanges();
            }
        }

        public Employee CheckLogin(string username, string password)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                Employee currentEmployee = _dbContext.Employees.FirstOrDefault(s => s.Username == username && s.Password == password);
                return currentEmployee;
            }
        }
        public List<Employee> GetAllEmployeesByAreaId(int areaId)
        {
            using (_dbContext = new Animal_Management_SystemContext())
            {
                List<Employee> employees = _dbContext.Employees.Where(e => e.AreaId == areaId).ToList();
                return employees;
            }
        }
    }
}