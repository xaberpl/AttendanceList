using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceList
{
    public partial class addStudent : Form
    {
        public addStudent()
        {
            InitializeComponent();

           
        }

        private void tName_TextChanged(object sender, EventArgs e)
        {

        }


        private void cancelClick(object sender, EventArgs e)
        {

            ActiveForm.Close();

        }

        private void saveClick(object sender, EventArgs e)
        {
            DatabaseClient db = new DatabaseClient();

            db.addStudent(tName.Text, tSurname.Text, tEmail.Text, tPesel.Text, tGender.Text, tParentsPhoneNumber.Text);
            ActiveForm.Close();
        }
    }
}
