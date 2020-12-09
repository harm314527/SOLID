using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInversionRight
{
    public class EmployeeManager : ISearchEmployee
    {
        private readonly List<Employee> employees;
       
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
        public List<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position)
        {
            List<Employee> comparedemployees = new List<Employee>();
            
            foreach (Employee employee in employees)
            {
                if(employee.Gender == gender && employee.Position == position)
                {
                    comparedemployees.Add(employee);
                }
            }
            return comparedemployees;
        }
    }
}
