using System;

namespace DependencyInversionWrong
{
    class Program
    {
        static void Main(string[] args)
        {
            var empManager = new EmployeeManager();
            empManager.AddEmployee(new Employee { Name = "Leen", Gender = Gender.Female, Position = Position.Manager });
            empManager.AddEmployee(new Employee { Name = "Mike", Gender = Gender.Male, Position = Position.Administrator });
            empManager.AddEmployee(new Employee { Name = "Maria", Gender = Gender.Female, Position = Position.Assistant });
            empManager.AddEmployee(new Employee { Name = "Bart", Gender = Gender.Male, Position = Position.Executive });
            empManager.AddEmployee(new Employee { Name = "Sandra", Gender = Gender.Female, Position = Position.Manager });
            empManager.AddEmployee(new Employee { Name = "Tom", Gender = Gender.Male, Position = Position.Manager });
            empManager.AddEmployee(new Employee { Name = "Monique", Gender = Gender.Female, Position = Position.Manager });
            empManager.AddEmployee(new Employee { Name = "Harm", Gender = Gender.Male, Position = Position.Assistant});
            empManager.AddEmployee(new Employee { Name = "Suzanne", Gender = Gender.Female, Position = Position.Manager });
            empManager.AddEmployee(new Employee { Name = "Niels", Gender = Gender.Male, Position = Position.Administrator });
            var stats = new EmployeeStatistics(empManager);
            Console.WriteLine($"Number of female managers in our company is: {stats.CountFemaleManagers()}");
        }
    }
}

