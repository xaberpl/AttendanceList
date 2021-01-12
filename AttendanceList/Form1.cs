using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Data.SqlClient;


namespace AttendanceList
{
    public partial class MainWindow : Form
    { 
        List<Student> students = new List<Student>();
        List<Attendance> attendances = new List<Attendance>();
        List<Attendance> attendances2 = new List<Attendance>();
        List<Teacher> teachers = new List<Teacher>();
        string loggedName;

        public MainWindow()
        {
        InitializeComponent();
        }

        void showStudentList()
        {
            DatabaseClient db = new DatabaseClient();
            
            students = db.GetAllStudents();

            studentList.Refresh();

            studentList.DataSource = students;
            studentList.DisplayMember = "DisplayName";

        }
        public string _textBox
        {
            set { loggedName = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showStudentList();
            studentList.SelectedIndex = -1;
            DatabaseClient db = new DatabaseClient();
            teachers = db.whoLogged(loggedName);
            label9.Text = "You are logged in as: " + teachers[0].DisplayName;             
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void studentClick(object sender, EventArgs e)
        {
            presentButton.BackColor = Color.Empty;
            absentButton.BackColor = Color.Empty;

            string text = studentList.GetItemText(studentList.SelectedItem);
            Student found = null;
            foreach (Student student in students)
            {
                if (student.DisplayName == text)
                {
                    found = student;
                }
            }
            if (found != null)
            {
                tName.Text = found.FirstName;
                tSurname.Text = found.LastName;
                tEmail.Text = found.EmailAddress;
                tPesel.Text = found.Pesel;
                tParentsPhoneNumber.Text = found.ParentsPhoneNumber;
                tGender.Text = found.Gender;

                string input = found.Pesel;
                string sub = input.Substring(0, 6);
                string iString = sub;
                DateTime oDate = DateTime.ParseExact(iString, "yyMMdd", null);
                string urodziny = oDate.ToString();
                tDateOfBirth.Text = urodziny.Substring(0, 10);

                var today = DateTime.Today;
                var age = today.Year - oDate.Year;
                if (oDate.Date > today.AddYears(-age)) age--;
                string wiek = age.ToString();
                tAge.Text = wiek;

                string studentID = found.id.ToString();
                
                DatabaseClient db = new DatabaseClient();
                teachers = db.whoLogged(loggedName);
                string teacherID = teachers[0].id.ToString();
                string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                
                attendances = db.getAttendance(studentID, teacherID, theDate);

                foreach (Attendance attendance in attendances)
                {                        
                    if (attendances[0].Presence == "False")
                    {
                        presentButton.BackColor = Color.Empty;
                        absentButton.BackColor = Color.Red;
                    }
                    else if (attendances[0].Presence == "True")
                    {
                        presentButton.BackColor = Color.Green;
                        absentButton.BackColor = Color.Empty;
                    }
                }              
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tName.Text = "";
            tSurname.Text = "";
            tEmail.Text = "";
            tPesel.Text = "";
            tGender.Text = "";
            tParentsPhoneNumber.Text = "";
            tDateOfBirth.Text = "";
            tAge.Text = "";
            absentButton.BackColor = Color.Empty;
            presentButton.BackColor = Color.Empty;
            studentList.SelectedIndex = -1;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tType_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void test1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            addStudent addstudent = new addStudent();
            DialogResult = addstudent.ShowDialog();
            showStudentList();
        }

        private void tEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tGender_TextChanged(object sender, EventArgs e)
        {

        }

        public void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void presentButton_Click(object sender, EventArgs e)
        {
            DatabaseClient db = new DatabaseClient();
           
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string studentID = null;
            string text = studentList.GetItemText(studentList.SelectedItem);
            Student found = null;

            foreach (Student student in students)
            {
                if (student.DisplayName == text)
                {
                    found = student;
                }
            }

            if (found != null)
            {
                studentID = found.id.ToString();
            }

            teachers = db.whoLogged(loggedName);
            string teacherID = teachers[0].id.ToString();           
            db.InsertAttendances(studentID, teacherID, theDate, "1");
            presentButton.BackColor = Color.Green;
            absentButton.BackColor = Color.Empty;
        }

        private void absentButton_Click(object sender, EventArgs e)
        {
            DatabaseClient db = new DatabaseClient();
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string studentID = null;              
            string text = studentList.GetItemText(studentList.SelectedItem);
            Student found = null;

            foreach (Student student in students)
            {
                if (student.DisplayName == text)
                {
                    found = student;
                }
            }

            if (found != null)
            {
                studentID = found.id.ToString();
            }

            teachers = db.whoLogged(loggedName);
            string teacherID = teachers[0].id.ToString();
            db.InsertAttendances(studentID, teacherID, theDate, "0");
            absentButton.BackColor = Color.Red;
            presentButton.BackColor = Color.Empty;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DatabaseClient db = new DatabaseClient();
            db.deleteStudent(tPesel.Text);
            students = db.GetAllStudents();
            showStudentList();
            studentList.SelectedIndex = -1;
            tName.Text = "";
            tSurname.Text = "";
            tEmail.Text = "";
            tPesel.Text = "";
            tGender.Text = "";
            tParentsPhoneNumber.Text = "";
            tDateOfBirth.Text = "";
            tAge.Text = "";
        }
    }
}