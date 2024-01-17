using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    using System;
    class Boxing
    {
        static public void Main()
        {
          int num = 2020;
            // boxing
            object obj = num;
            // value of num to be change
            num = 100;
           Console.WriteLine("Value - type value of num is : {0}", num);
           Console.WriteLine("Object - type value of obj is : {0}", obj);
        }
    }
}
