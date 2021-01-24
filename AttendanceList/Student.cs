using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceList
{
    public class Student
    {
        public int id { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentEmailAddress { get; set; }
        public string ParentsPhoneNumber { get; set; }
        public string Pesel { get; set; }
        public string Gender { get; set; }


        public string DisplayName
        {
            get
            {
                return $"{ StudentLastName } { StudentFirstName }";
            }
        }
    }
}
