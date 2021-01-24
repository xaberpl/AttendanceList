
namespace AttendanceList
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.Label();
            this.tSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tDateOfBirth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tGender = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tPesel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tParentsPhoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.presentButton = new System.Windows.Forms.Button();
            this.absentButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentList
            // 
            this.studentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentList.FormattingEnabled = true;
            this.studentList.ItemHeight = 15;
            this.studentList.Location = new System.Drawing.Point(15, 41);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(199, 409);
            this.studentList.Sorted = true;
            this.studentList.TabIndex = 0;
            this.studentList.Click += new System.EventHandler(this.studentClick);
            this.studentList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(230, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(232, 104);
            this.tName.Name = "tName";
            this.tName.ReadOnly = true;
            this.tName.Size = new System.Drawing.Size(257, 20);
            this.tName.TabIndex = 5;
            this.tName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lastname
            // 
            this.Lastname.AutoSize = true;
            this.Lastname.Location = new System.Drawing.Point(229, 132);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(49, 13);
            this.Lastname.TabIndex = 9;
            this.Lastname.Text = "Surname";
            this.Lastname.Click += new System.EventHandler(this.label3_Click);
            // 
            // tSurname
            // 
            this.tSurname.Location = new System.Drawing.Point(232, 148);
            this.tSurname.Name = "tSurname";
            this.tSurname.ReadOnly = true;
            this.tSurname.Size = new System.Drawing.Size(257, 20);
            this.tSurname.TabIndex = 8;
            this.tSurname.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date of birth";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tDateOfBirth
            // 
            this.tDateOfBirth.Location = new System.Drawing.Point(232, 293);
            this.tDateOfBirth.Name = "tDateOfBirth";
            this.tDateOfBirth.ReadOnly = true;
            this.tDateOfBirth.Size = new System.Drawing.Size(257, 20);
            this.tDateOfBirth.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gender";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tGender
            // 
            this.tGender.Location = new System.Drawing.Point(232, 243);
            this.tGender.Name = "tGender";
            this.tGender.ReadOnly = true;
            this.tGender.Size = new System.Drawing.Size(257, 20);
            this.tGender.TabIndex = 12;
            this.tGender.TextChanged += new System.EventHandler(this.tGender_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pesel";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tPesel
            // 
            this.tPesel.Location = new System.Drawing.Point(232, 339);
            this.tPesel.Name = "tPesel";
            this.tPesel.ReadOnly = true;
            this.tPesel.Size = new System.Drawing.Size(257, 20);
            this.tPesel.TabIndex = 14;
            this.tPesel.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Parent\'s phone number";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // tParentsPhoneNumber
            // 
            this.tParentsPhoneNumber.Location = new System.Drawing.Point(232, 390);
            this.tParentsPhoneNumber.Name = "tParentsPhoneNumber";
            this.tParentsPhoneNumber.ReadOnly = true;
            this.tParentsPhoneNumber.Size = new System.Drawing.Size(257, 20);
            this.tParentsPhoneNumber.TabIndex = 16;
            this.tParentsPhoneNumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "E-mail";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(232, 196);
            this.tEmail.Name = "tEmail";
            this.tEmail.ReadOnly = true;
            this.tEmail.Size = new System.Drawing.Size(257, 20);
            this.tEmail.TabIndex = 22;
            this.tEmail.TextChanged += new System.EventHandler(this.tEmail_TextChanged);
            // 
            // tAge
            // 
            this.tAge.Location = new System.Drawing.Point(232, 434);
            this.tAge.Name = "tAge";
            this.tAge.ReadOnly = true;
            this.tAge.Size = new System.Drawing.Size(257, 20);
            this.tAge.TabIndex = 24;
            this.tAge.TextChanged += new System.EventHandler(this.tType_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Age";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // presentButton
            // 
            this.presentButton.Location = new System.Drawing.Point(230, 467);
            this.presentButton.Name = "presentButton";
            this.presentButton.Size = new System.Drawing.Size(115, 40);
            this.presentButton.TabIndex = 27;
            this.presentButton.Text = "Present";
            this.presentButton.UseVisualStyleBackColor = true;
            this.presentButton.Click += new System.EventHandler(this.presentButton_Click);
            // 
            // absentButton
            // 
            this.absentButton.Location = new System.Drawing.Point(367, 467);
            this.absentButton.Name = "absentButton";
            this.absentButton.Size = new System.Drawing.Size(122, 40);
            this.absentButton.TabIndex = 26;
            this.absentButton.Text = "Absent";
            this.absentButton.UseVisualStyleBackColor = true;
            this.absentButton.Click += new System.EventHandler(this.absentButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 569);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "label9";
            this.label9.TextChanged += new System.EventHandler(this.label9_TextChanged);
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(69, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "List of students";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(323, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Calendar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(305, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Student details";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 513);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 40);
            this.button4.TabIndex = 36;
            this.button4.Text = "Remove student";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 39);
            this.button2.TabIndex = 37;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 591);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.presentButton);
            this.Controls.Add(this.absentButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tAge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tParentsPhoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tPesel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tDateOfBirth);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.tSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.studentList);
            this.Name = "MainWindow";
            this.Text = "AttendanceList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox studentList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.TextBox tSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tDateOfBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tPesel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tParentsPhoneNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button presentButton;
        private System.Windows.Forms.Button absentButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
    }
}

