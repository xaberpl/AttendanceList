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
        public string text { get; set; }

        string text2;

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

        }

        private void tLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButtonClick(object sender, EventArgs e)
        {
            DatabaseClient db = new DatabaseClient();
            text = tLogin.Text;
            text2 = tPassword.Text;

            teachers = db.Login(text);
            bool loginPasswordCorrect = false;
            foreach (Teacher teacher in teachers)

            { 
                if (text == teacher.Login && text2 == teacher.Password)
                {
                    this.Hide();
                    var mainWindow = new MainWindow();
                    mainWindow.Closed += (s, args) => this.Close();
                    mainWindow._textBox = _textBox1;
                    mainWindow.Show();
                    loginPasswordCorrect = true;
                    break;
                }              
            }
            if (!loginPasswordCorrect)
            {
                MessageBox.Show("Incorrect login or password");
            }
        }
        public string _textBox1
        {
            get { return tLogin.Text; }
        }
    }   
}
