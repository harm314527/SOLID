using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrincipleRight
{
    class Teamlead : IBoss, IProgrammer
    {
        public void Work()
        {
            AssginTask();
            CreateSubTask();
            WorkOnTask();
        }
        public void AssginTask()
        {
            Console.WriteLine("Teamleader assigned a task to a Programmer");
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
