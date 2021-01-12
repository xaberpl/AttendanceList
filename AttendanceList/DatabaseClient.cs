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

        internal void InsertAttendances(string studentID, string teacherID, string data, string presence)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FirstDB")))
            {
                List<Attendance> attendances = new List<Attendance>();

                attendances.Add(new Attendance { StudentID = studentID, TeacherID = teacherID, Data = data, Presence = presence });

                connection.Execute("dbo.Attendance_Insert2 @StudentID, @TeacherID, @Data, @Presence", attendances);
            }
        }

        internal void addStudent(string text1, string text2, string text3, string text4, string text5, string text6)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FirstDB")))
            {
                List<Student> students = new List<Student>();

                students.Add(new Student { FirstName = text1, LastName = text2, EmailAddress = text3, Pesel = text4, Gender = text5, ParentsPhoneNumber = text6 });

                connection.Execute("dbo.Students_Insert @FirstName, @LastName, @EmailAddress, @Pesel, @Gender, @ParentsPhoneNumber", students);
            }
        }
        public List<Teacher> Login(string login)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FirstDB")))
            {
                return connection.Query<Teacher>($"select * from Teachers where Login = '{ login }'").ToList();
            }
        }

        public List<Teacher> whoLogged(string login)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FirstDB")))
            {
                return connection.Query<Teacher>($"select * from Teachers where login = '{ login }'").ToList();
            }
        }
        public List<Attendance> getAttendance(string studentid, string teacherid, string data)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FirstDB")))
            {
                return connection.Query<Attendance>($"SELECT Presence FROM Attendance WHERE StudentID = '{ studentid }' AND TeacherID = '{ teacherid }' AND Data = '{ data }' ").ToList();
            }
        }

        internal void studentDelete(string pesel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FirstDB")))
            {
                List<Student> students = new List<Student>();

                students.Add(new Student { Pesel = pesel });

                connection.Execute("dbo.Student_Delete @Pesel", students);
            }
        }
        public List<Student> deleteStudent(string pesel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FirstDB")))
            {
                return connection.Query<Student>($"DELETE from Students where pesel = '{ pesel }'").ToList();
            }
        }
    }
}

