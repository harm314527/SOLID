using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrincipleWrong
{
    class Programmer : ITasks
    {
        public void Work()
        {
            AssginTask();
            CreateSubTask();
            WorkOnTask();
        }
        public void AssginTask()
        {
            Console.WriteLine("ERROR: Programmer cant assign tasks");
        }

        public void CreateSubTask()
        {
            Console.WriteLine("ERROR: Programmer cant create a subtask");
        }

        public void WorkOnTask()
        {
            Console.WriteLine("Programmer Working on a task");
        }
    }
}
