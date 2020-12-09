using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrincipleRight
{
    class Manager : IBoss
    {
        public void AssginTask()
        {
            Console.WriteLine("Manager assigned a task to a Teamleader");
        }

        public void CreateSubTask()
        {
            Console.WriteLine("Manager created a subtask");
        }

        public void Work()
        {
            AssginTask();
            CreateSubTask();
        }
    }
}
