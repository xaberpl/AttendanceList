using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceList
{
    class User
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }

        public string DisplayName
        {
            get
            {
                return $"{ LastName } { FirstName }";

            }
        }
    }
}
