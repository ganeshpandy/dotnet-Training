using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vechicle
{
    class car
    {
        public static string name="Audi";
        public static string model = "abc123";
        public static string color = "red";
        public static void start() {
            Console.WriteLine("Your car has started");
        }
        public static void drive() { 
            Console.WriteLine("driving the car");
        }
    }
}
