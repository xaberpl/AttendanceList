using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace AttendanceList
{
    class DatabaseClient
    {
        public List<User> GetUsers(string LastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseHelper.CnnVal("FirstDB")))
            {
                return connection.Query<User>($"select * from Users where LastName = '{ LastName }'").ToList();
            }
        }

        public List<Student> GetAllStudents()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseHelper.CnnVal("FirstDB")))
            {
                return connection.Query<Student>($"SELECT * FROM Students ").ToList();
            }
        }

        internal void InsertAttendances(string studentID, string teacherID, string data, string presence)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseHelper.CnnVal("FirstDB")))
            {
                List<Attendance> attendances = new List<Attendance>();

                attendances.Add(new Attendance { StudentID = studentID, TeacherID = teacherID, Data = data, Presence = presence });

                connection.Execute("dbo.Attendance_Insert2 @StudentID, @TeacherID, @Data, @Presence", attendances);
            }
        }

        internal void addStudent(string text1, string text2, string text3, string text4, string text5, string text6)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseHelper.CnnVal("FirstDB")))
            {
                List<Student> students = new List<Student>();

                students.Add(new Student { StudentFirstName = text1, StudentLastName = text2, StudentEmailAddress = text3, Pesel = text4, Gender = text5, ParentsPhoneNumber = text6 });

                connection.Execute("dbo.Students_Insert @StudentFirstName, @StudentLastName, @StudentEmailAddress, @Pesel, @Gender, @ParentsPhoneNumber", students);
            }
        }
        public List<Teacher> Login(string login)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseHelper.CnnVal("FirstDB")))
            {
                return connection.Query<Teacher>($"select * from Teachers where Login = '{ login }'").ToList();
            }
        }

        public List<Teacher> whoLogged(string login)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseHelper.CnnVal("FirstDB")))
            {
                return connection.Query<Teacher>($"select * from Teachers where login = '{ login }'").ToList();
            }
        }
        public List<Attendance> getAttendance(string studentid, string teacherid, string data)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseHelper.CnnVal("FirstDB")))
            {
                return connection.Query<Attendance>($"SELECT Presence FROM Attendance WHERE StudentID = '{ studentid }' AND TeacherID = '{ teacherid }' AND Data = '{ data }' ").ToList();
            }
        }

        public List<Student> deleteStudent(string pesel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseHelper.CnnVal("FirstDB")))
            {
                return connection.Query<Student>($"DELETE from Students where pesel = '{ pesel }'").ToList();
            }
        }

        public List<JoinAttendance> joinAttendences()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DatabaseHelper.CnnVal("FirstDB")))
            {
                return connection.Query<JoinAttendance>($"SELECT * FROM dbo.Students INNER JOIN dbo.Attendance ON dbo.Students.id = dbo.Attendance.StudentID INNER JOIN dbo.Teachers ON dbo.Teachers.ID = dbo.Attendance.TeacherID; ").ToList();
                //return connection.Query<JoinAttendance>($"SELECT Presence FROM Attendance WHERE StudentID = '{ studentid }' AND TeacherID = '{ teacherid }' AND Data = '{ data }' ").ToList();
            }
        }
    }
}

