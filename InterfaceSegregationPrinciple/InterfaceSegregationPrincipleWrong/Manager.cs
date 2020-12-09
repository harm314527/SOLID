using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrincipleWrong
{
    class Manager : ITasks
    {
        public void Work()
        {
            AssginTask();
            CreateSubTask();
            WorkOnTask();
        }
        public void AssginTask()
        {
            Console.WriteLine("Manager assigned a task to an employee");
        }

        public void CreateSubTask()
        {
            Console.WriteLine("Manager created a subtask");
        }

        public void WorkOnTask()
        {
            Console.WriteLine("ERROR: Manager cant work on task");
        }
    }
}
