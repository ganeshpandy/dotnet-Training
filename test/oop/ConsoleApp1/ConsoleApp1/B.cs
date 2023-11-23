/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class A
    {
       public int ValueA;
        public int ValueB;
        public A(int ValueA,int ValueB) 
        {
            this.ValueA = ValueA;
            this.ValueB = ValueB;   
        }
        public  int DisplayValue(int ValueA,int ValueB) 
        {
            return ValueA + ValueB;    
        }
    }
    class B :A
    {
        public int ValueC;
        public B(int ValueA, int ValueB, int ValueC) : base(ValueA, ValueB) 
        {
        this.ValueC= ValueC;
        }
        public  int DisplayValue(int ValueA, int ValueB,int ValueC)
        {
            //return DisplayValue(ValueA, ValueB,ValueC);
           return ValueA + ValueB + ValueC;
        }
    }
    class MainMethod 
    {
        public static void Main(string[] args) 
        {
            B b = new B(1,2,3);
            Console.WriteLine(b.DisplayValue(1, 2));
            Console.WriteLine(b.DisplayValue(1, 2,3));
            // A a = new A(4, 5);
            // Console.WriteLine(a.DisplayValue(4, 5));

            
        }
    }
}
*/