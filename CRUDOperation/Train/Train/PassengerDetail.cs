using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
     class PassengerDetail
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Arrival { get; set; }
        public string? Departure { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public long PhNo { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
    //Id,Name,Arrival,Departure,Age,Gender,Phno,Date
}
