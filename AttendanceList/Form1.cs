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
    public partial class Form1 : Form
    { 
        List<Student> students = new List<Student>();
        List<Attendance> attendances = new List<Attendance>();
        List<Teacher> teachers = new List<Teacher>();
        string loggedName;

        public Form1()
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
            presentButton.BackColor = Color.Green;

            /*DatabaseClient db = new DatabaseClient();
            db.InsertAttendances(test1.Text, test2.Text, test3.Text, test4.Text);
            test1.Text = "";
            test2.Text = "";
            test3.Text = "";
            test4.Text = "";    */
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

    }
}