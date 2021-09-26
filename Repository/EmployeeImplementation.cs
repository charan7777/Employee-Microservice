using Employee_Microservice.Models;
using Employee_Microservice_Final_Project_.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Microservice_Final_.RepositoryImplementation
{
    public class EmployeeImplementation : IEmployeeRepo
    {
        private readonly CoreDbContext _dbContext;
        // constructor called
        public EmployeeImplementation(CoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //delete
        public void RemoveEmployee(int EmpId)
        {
            var product = _dbContext.Educations.Find(EmpId);
            _dbContext.Educations.Remove(product);
            Save();
        }

        //Retrieve employees by ID
        public Employee GetEmployeeById(int EmpId)
        {
            return _dbContext.Employees.Find(EmpId);
        }

        // Retrieve all employees
        public IEnumerable<Employee> GetEmployees()
        {
            return _dbContext.Employees.ToList();
        }

        //Add new employee

        public void AddEmployee(Employee emp)
        {
            _dbContext.Add(emp);
            Save();
        }

        // Save operation 
        public void Save()
        {
            _dbContext.SaveChanges();
        }

        // Update Employee details
        public void UpdateEmployeeDetails(Employee emp)
        {
            _dbContext.Entry(emp).State = EntityState.Modified;
            Save();
        }


    }
}
