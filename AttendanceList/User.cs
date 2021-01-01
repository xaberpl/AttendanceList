using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceList
{
    class User
    {
        private String name;
        private String surname;
        private String username;
        private String password;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public User(string aName, string aSurname, string aUsername, string aPassword)
        {
            name = aName;
            surname = aSurname;
            username = aUsername;
            password = aPassword;
        }

    }

}
