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

        List<User> users = new List<User>();
        


        private void UpdateBinding()
        {
            peopleFoundListbox.DataSource = users;
            peopleFoundListbox.DisplayMember = "FullInfo" ;
        }

        

        public Form1()
        {
            InitializeComponent();
            UpdateBinding();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            LoginWindow okno = new LoginWindow();
            DialogResult = okno.ShowDialog();

            DatabaseClient db = new DatabaseClient();

            users = db.GetAllStudents();

            studentList.Refresh();
           
            studentList.DataSource = users;
            studentList.DisplayMember = "DisplayName";
            

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            DatabaseClient db = new DatabaseClient();

            users = db.GetAllStudents();

            peopleFoundListbox.Refresh();

            UpdateBinding();
        }

        private void studentClick(object sender, EventArgs e)
        {
            string text = studentList.GetItemText(studentList.SelectedItem);
            User found = null;
            foreach (User user in users)
            {
                if (user.DisplayName == text)
                {
                    found = user;
                }
            }
            if (found != null)
            {
                tName.Text = found.FirstName;
                tSurname.Text = found.LastName;
                tEmail.Text = found.EmailAddress;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}