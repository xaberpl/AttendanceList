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

        /*public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ParentsPhoneNumber { get; set; }
        public string Pesel { get; set; }
        public string Gender { get; set; }
*/



        /* public string DisplayName
         {
             get
             {
                 return $"{ FirstName } { LastName }";

             }
         }*/
    }
}
