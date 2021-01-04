using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceList
{
    class Attendance
    {
        public int StudentID { get; set; }
        public int TeacherID { get; set; }
        public string Data { get; set; }
        public int Presence { get; set; }
    }
}
