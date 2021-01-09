using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AttendanceList
{
    public partial class LoginWindow : Form
    {
        List<Teacher> teachers = new List<Teacher>();
        //public String login;
        //public String pass;
        public LoginWindow()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //login = tLogin.Text;
            //pass = tPassword.Text;
            //this.Dispose();
        }

        private void tLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButtonClick(object sender, EventArgs e)
        {
            DatabaseClient db = new DatabaseClient();
            string text = tLogin.Text;
            string text2 = tPassword.Text;
            //Teacher found = null;
            teachers = db.Login(text);
            int i = 0;
            foreach (Teacher teacher in teachers)

            {

                if (text == teacher.Login && text2 == teacher.Password)
                {
                    this.Hide();
                    var mainWindow = new Form1();
                    mainWindow.Closed += (s, args) => this.Close();
                    mainWindow.Show();
                    i++;
                    break;
                }              
            }         
            if (text != (db.Login(text)).ToString())
            {
                if(i == 1)
                {
                    i++;
                }    
                else
                    MessageBox.Show("Incorrect login or password");
            }
        }
    }   
}
