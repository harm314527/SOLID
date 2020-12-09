using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrincipleRight
{
    class Programmer : IProgrammer
    {
        public void Work()
        {
            WorkOnTask();
        }

        public void WorkOnTask()
        {
            Console.WriteLine("Programmer Working on a task");
        }
    }
}
