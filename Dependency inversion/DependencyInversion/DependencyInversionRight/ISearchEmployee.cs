using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionRight
{
    interface ISearchEmployee
    {
        List<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position);
    }
}
