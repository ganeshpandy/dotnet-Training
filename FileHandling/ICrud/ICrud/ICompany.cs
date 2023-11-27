using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICrud
{
     interface ICompany
    {
        void Create();
        void Update();
        void Delete();
        void Read();
    }
}
