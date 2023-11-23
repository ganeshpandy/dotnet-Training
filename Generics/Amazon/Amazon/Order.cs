using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
     class Order
    {
        public int Id { get; set; }
        public string Name {  get; set; }
        public string OrderType {  get; set; }
        public string MobileName {  get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public double Amount {  get; set; }
        public long PhNo { get; set; }
    }
}
