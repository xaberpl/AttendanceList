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

        List<Teacher> teacher = new List<Teacher>();
           
        private void UpdateBinding()
        {
            peopleFoundListbox.DataSource = teacher;
            peopleFoundListbox.DisplayMember = "FullInfo";
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
            DataAccess db = new DataAccess();

            teacher = db.GetTeacher(lastNameText.Text);

            peopleFoundListbox.Refresh();

            UpdateBinding();

        }
    }
}
