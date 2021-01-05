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
        //konkretny użytkownik o wpisanym nazwisku zostanie wyświetlony w wyszukiwarce
        public List<User> GetUsers(string LastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FirstDB")))
            {
                return connection.Query<User>($"select * from Users where LastName = '{ LastName }'").ToList();
            }
        }

        //po kliknięciu wyszukaj, pokaże liste wszystkich użytkowników zapisanych w bazie danych
        public List<User> GetUsers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FirstDB")))
            {
                return connection.Query<User>($"select * from Users").ToList();
            }
        }

        //gdy wpisze Teacher w wyszukiwarke, wyświetli mi wszystkich teacherów
        public List<User> GetTeacher(string Type)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FirstDB")))
            {
                return connection.Query<User>($"select * from Users where Type = '{ Type }'").ToList();
            }
        }

        //po kliknięciu Search, wyswietli nam imiona wszystkich nauczycieli
        public List<User> GetAllTeachers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FirstDB")))
            {
                return connection.Query<User>($"SELECT * FROM Users WHERE Type = 'Teacher' ").ToList();
            }
        }

        //wyświetla liste wszystkich studentów
        public List<Student> GetAllStudents()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FirstDB")))
            {
                return connection.Query<Student>($"SELECT * FROM Students ").ToList();
            }
        }

        public List<User> GetStudent(string name, string lastname)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FirstDB")))
            {
                return connection.Query<User>($"select * from Users where FirstName = '{ name }' AND LastName = '{ lastname }'").ToList();
            }
        }

        internal void InsertAttendances(string text1, string text2, string text3, string text4)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FirstDB")))
            {

                //Attendance newAttendance = new Attendance { StudentID = text1, TeacherID = text2, Data = text3, Presence = text4};
                List<Attendance> attendances = new List<Attendance>();

                attendances.Add(new Attendance { StudentID = text1, TeacherID = text2, Data = text3, Presence = text4 });
                
                connection.Execute("dbo.Attendance_Insert @StudentID, @TeacherID, @Data, @Presence", attendances);
            }
        }
    }
}

