using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrincipleRight
{
    interface IBoss : IWork
    {
        void Work();
        void CreateSubTask();
        void AssginTask();
    }
}
