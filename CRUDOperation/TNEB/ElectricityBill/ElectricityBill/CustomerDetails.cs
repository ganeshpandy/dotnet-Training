using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBill
{
     class CustomerDetails<T>
    {
        public T CustomerID { get; set; }
        public T CustomerName { get; set; }
        public T Address {  get; set; }
        public T Phno { get; set; }
    }
}
//CustomerID,CustomerName,Address,Phno
