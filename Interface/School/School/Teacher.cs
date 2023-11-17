using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher{ 

        public  int StaffId { get; set; }
        public string StaffName { get; set; }
        public string Class { get; set; }
        public string Subject { get; set; }
        public Teacher(int StaffId, string StaffName, string Class, string Subject)  {
            this.StaffId = StaffId;
            this.StaffName = StaffName;
            this.Class = Class;
            this.Subject = Subject;
        }
    }
}
