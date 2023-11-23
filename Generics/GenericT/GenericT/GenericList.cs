using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericT
{
     class GenericList<T>
    {
        public T Name { get; set; }
        public T Id { get; set; }
        public T Address { get; set; }
        public T Salary { get; set; }
        public T Phno { get; set; }
        public T DOJ { get; set; }
        public T GetName(){ return Name; }
        public T GetAddress(){ return Address; }
        public T GetId(){ return Id; }
        public T GetSalary() { return Salary; }
        public T GetPhno() {  return Phno; }
        public T GetDOJ() {  return DOJ; }

        public void Display(T value) 
        {
        Console.WriteLine(value);
        }



    }
}
