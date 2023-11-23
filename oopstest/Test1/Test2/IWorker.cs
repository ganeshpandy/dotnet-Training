using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
     interface IWorker
    {
        void Enrollment();
        void Dispatch();
        int GetworkerID();

    }
}
/*Declare three methods in the IWorker interface:
Enrollment with no parameters and a return type of void.
Dispatch with no parameters and a return type of void.
GetworkerID with no parameters and a return type of int.*/