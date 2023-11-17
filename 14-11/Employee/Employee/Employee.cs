using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
     class Employee
    {
        /*public int Id = 0;
        public string? Name = "";
        public string? EmailId = "";
        public string? Address = "";
        public long PhoneNo = 0;*/
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public long PhoneNo { get; set; }
        public Employee(int Id, string Name, string EmailId, string Address, long PhoneNo)
        {
            this.Id = Id;
            this.Name = Name;
            this.EmailId = EmailId;
            this.Address = Address;
            this.PhoneNo = PhoneNo;

        }
    }
}
