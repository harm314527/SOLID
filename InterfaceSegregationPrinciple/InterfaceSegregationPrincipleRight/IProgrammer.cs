using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrincipleRight
{
    interface IProgrammer : IWork
    {
        void Work();
        void WorkOnTask();
    }
}
