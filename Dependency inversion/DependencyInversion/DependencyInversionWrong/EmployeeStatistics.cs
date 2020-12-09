using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionWrong
{
    class EmployeeStatistics
    {
        private readonly EmployeeManager empManager;
        public EmployeeStatistics(EmployeeManager empManager)
        {
            this.empManager = empManager;
        }
        public int CountFemaleManagers()
        {
            int count = 0;
            foreach(Employee emp in empManager.Employees)
            {
                if(emp.Gender == Gender.Female && emp.Position == Position.Manager)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
