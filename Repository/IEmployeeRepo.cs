using Employee_Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Microservice_Final_Project_.Repository
{
    public interface IEmployeeRepo
    {
        // these methods are used to perform crud operations.
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int EmpId);

        void AddEmployee(Employee Emp);
        void RemoveEmployee(int EmpId);

        void UpdateEmployeeDetails(Employee Emp);
        void Save();
    }
}
