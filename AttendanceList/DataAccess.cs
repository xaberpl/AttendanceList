using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace AttendanceList
{
    class DataAccess
    {
        public List<Teacher> GetTeacher(string LastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FirstDB")))
            {
                return connection.Query<Teacher>($"select * from Teacher where LastName = '{ LastName }'").ToList();

            }
        }
    }   
}

