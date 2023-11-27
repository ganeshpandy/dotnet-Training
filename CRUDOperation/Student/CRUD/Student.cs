using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
     class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Standard { get; set; }
        public long Phoneno { get; set; }
        public double Fees { get; set; }
        public DateOnly DOJ { get; set; } = new DateOnly();
        public DateOnly DOB { get; set; } = new DateOnly();
    }
}
