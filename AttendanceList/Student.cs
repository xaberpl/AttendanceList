using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceList
{
    class Student : User
    {
        public string ParentsPhoneNumber { get; set; }
        public string Pesel { get; set; }
        public string Gender { get; set; }
    }
}
