using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceList
{
    public class Teacher
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public int id { get; set; }
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }
        public string TeacherEmailAddress { get; set; }

        public string DisplayName
        {
            get
            {
                return $"{ TeacherLastName } { TeacherFirstName }";
            }
        }
    }
}
