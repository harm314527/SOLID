using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionWrong
{
    public class EmployeeManager 
    {
        private readonly List<Employee> employees;
        public List<Employee> Employees => employees;
        public EmployeeManager()
        {
            employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
        }
    }
}
