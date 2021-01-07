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
            string error = null;
            List<Student> students = new List<Student>();
            DatabaseClient db = new DatabaseClient();

            string chargedName = tName.Text;
            string chargedSurname = tSurname.Text;
            string chargedPesel = tPesel.Text;
            string chargedParentsPhoneNumber = tParentsPhoneNumber.Text;
            string chargedEmail = tEmail.Text;

            Student found = null;
            foreach (Student student in students)
            {
                if (student.Pesel == chargedPesel)
                {
                    found = student;
                }
            }
            //CHECKING IS IN DB STUDENT WITH SAME PESEL
            if (found != null)
            {
                error += "There is already student with same pesel!" + Environment.NewLine;
            }

            //NAME
            if (chargedName.Length < 2 || chargedName.Length > 25)
            {
                error += "Firstname must have leght 2-25 letters" + Environment.NewLine;
            }
            bool isLetterName = chargedName.All(char.IsLetter);
            if (isLetterName == false)
            {
                error += "The firstname cannot have numbers or special characters!" + Environment.NewLine;
            }

            //SURNAME
            if (chargedSurname.Length < 2 || chargedSurname.Length > 25)
            {
                error += "Surname must have leght 2-25 letters" + Environment.NewLine;
            }
            bool isLetterSurname = chargedSurname.All(char.IsLetter);
            if (isLetterSurname == false)
            {
                error += "The surname cannot have digits or special characters!" + Environment.NewLine;
            }


            bool IsValidEmail(string email)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email;
                }
                catch
                {
                    return false;
                }
            }

            //EMAIL
            if ((IsValidEmail(chargedEmail)) == false)
            {
                error += "Mail address is incorrect" + Environment.NewLine;
            }

            //PESEL
            if (chargedPesel.Length !=11)
            {
                error += "Pesel must consist of 11 digits!" + Environment.NewLine;
            }
            bool isIntString = chargedPesel.All(char.IsDigit);
            if (isIntString == false)
            {
                error += "Pesel must be only digits!" + Environment.NewLine;
            }

            //PHONE
            bool isIntParentsPhoneNumber = chargedParentsPhoneNumber.All(char.IsDigit);
            if (isIntParentsPhoneNumber == false)
            {
                error += "Phone number must be only digits" + Environment.NewLine;
            }
            if (chargedParentsPhoneNumber.Length < 7 || chargedParentsPhoneNumber.Length > 15)
            {
                error += "Phone must have leght 7-15 digits" + Environment.NewLine;
            }


            //ADD STUDENT METHOD
            if (error == null)
            {
                db.addStudent(tName.Text, tSurname.Text, tEmail.Text, tPesel.Text, tGender.Text, tParentsPhoneNumber.Text);

                students = db.GetAllStudents();

                
                

                ActiveForm.Close();
            }


            else MessageBox.Show(error);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //void error(string x)
        //{
        //    error = error + x;
        //}
    }
}
