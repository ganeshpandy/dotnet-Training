using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    interface Iteacher
    {
        void DisplayTeacherDetails(int StaffId, string StaffName, string Class, string Subject);
        void DisplayStudentDetails(int Id, string Name);
    }
}
