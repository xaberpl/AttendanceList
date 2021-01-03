
namespace AttendanceList
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.tName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.peopleFoundListbox = new System.Windows.Forms.ListBox();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentList
            // 
            this.studentList.FormattingEnabled = true;
            this.studentList.Location = new System.Drawing.Point(12, 22);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(189, 485);
            this.studentList.TabIndex = 0;
            this.studentList.Click += new System.EventHandler(this.studentClick);
            this.studentList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(398, 531);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(250, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(258, 531);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(258, 133);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(113, 20);
            this.tName.TabIndex = 5;
            this.tName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Student details ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lastname
            // 
            this.Lastname.AutoSize = true;
            this.Lastname.Location = new System.Drawing.Point(391, 117);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(49, 13);
            this.Lastname.TabIndex = 9;
            this.Lastname.Text = "Surname";
            this.Lastname.Click += new System.EventHandler(this.label3_Click);
            // 
            // tSurname
            // 
            this.tSurname.Location = new System.Drawing.Point(394, 133);
            this.tSurname.Name = "tSurname";
            this.tSurname.Size = new System.Drawing.Size(113, 20);
            this.tSurname.TabIndex = 8;
            this.tSurname.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date of birth";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tDateOfBirth
            // 
            this.tDateOfBirth.Location = new System.Drawing.Point(258, 286);
            this.tDateOfBirth.Name = "tDateOfBirth";
            this.tDateOfBirth.Size = new System.Drawing.Size(113, 20);
            this.tDateOfBirth.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gender";
            // 
            // tGender
            // 
            this.tGender.Location = new System.Drawing.Point(258, 234);
            this.tGender.Name = "tGender";
            this.tGender.Size = new System.Drawing.Size(113, 20);
            this.tGender.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pesel";
            // 
            // tPesel
            // 
            this.tPesel.Location = new System.Drawing.Point(394, 183);
            this.tPesel.Name = "tPesel";
            this.tPesel.Size = new System.Drawing.Size(113, 20);
            this.tPesel.TabIndex = 14;
            this.tPesel.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Parent\'s phone number";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // tParentsPhoneNumber
            // 
            this.tParentsPhoneNumber.Location = new System.Drawing.Point(394, 234);
            this.tParentsPhoneNumber.Name = "tParentsPhoneNumber";
            this.tParentsPhoneNumber.Size = new System.Drawing.Size(113, 20);
            this.tParentsPhoneNumber.TabIndex = 16;
            this.tParentsPhoneNumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // peopleFoundListbox
            // 
            this.peopleFoundListbox.FormattingEnabled = true;
            this.peopleFoundListbox.Location = new System.Drawing.Point(251, 396);
            this.peopleFoundListbox.Name = "peopleFoundListbox";
            this.peopleFoundListbox.Size = new System.Drawing.Size(120, 95);
            this.peopleFoundListbox.TabIndex = 18;
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(398, 415);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(100, 20);
            this.surnameText.TabIndex = 19;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(399, 396);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 20;
            this.lastNameLabel.Text = "Last Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(402, 442);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 21;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "E-mail";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(258, 183);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(113, 20);
            this.tEmail.TabIndex = 22;
            // 
            // tAge
            // 
            this.tAge.Location = new System.Drawing.Point(394, 286);
            this.tAge.Name = "tAge";
            this.tAge.Size = new System.Drawing.Size(113, 20);
            this.tAge.TabIndex = 24;
            this.tAge.TextChanged += new System.EventHandler(this.tType_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Age";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 580);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tAge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.peopleFoundListbox);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.studentList);
            this.Name = "Form1";
            this.Text = "AttendanceList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox studentList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.ListBox peopleFoundListbox;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tAge;
        private System.Windows.Forms.Label label7;
    }
}

