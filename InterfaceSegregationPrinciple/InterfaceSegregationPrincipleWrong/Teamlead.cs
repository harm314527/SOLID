using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrincipleWrong
{
    class Teamlead : ITasks
    {
        public void Work()
        {
            AssginTask();
            CreateSubTask();
            WorkOnTask();
        }
        public void AssginTask()
        {
            Console.WriteLine("Teamleader assigned a task to an employee");
        }

        public void CreateSubTask()
        {
            Console.WriteLine("Teamleader created a subtask");
        }

        public void WorkOnTask()
        {
            Console.WriteLine("Teamleader Working on a task");
        }
    }
}
