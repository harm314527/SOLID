using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionRight
{
    class EmployeeStatistics
    {
        private readonly ISearchEmployee empManager;
        public EmployeeStatistics(ISearchEmployee empManager)
        {
            this.empManager = empManager;
        }
        public int CountFemaleManagers()
        { 
            return empManager.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count; 
        }
    }
}
