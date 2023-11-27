using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeByInterface
{
     interface IEmployee
    {
        List<EmployeeDetails>Create();
        void Update();
        void Delete();
        void Read();
    }
}
