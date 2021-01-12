
namespace AttendanceList
{
    partial class addStudent
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
            this.label8 = new System.Windows.Forms.Label();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tParentsPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tPesel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.Label();
            this.tSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "E-mail";
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(12, 143);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(152, 20);
            this.tEmail.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Parent\'s phone number";
            // 
            // tParentsPhoneNumber
            // 
            this.tParentsPhoneNumber.Location = new System.Drawing.Point(191, 194);
            this.tParentsPhoneNumber.Name = "tParentsPhoneNumber";
            this.tParentsPhoneNumber.Size = new System.Drawing.Size(160, 20);
            this.tParentsPhoneNumber.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Pesel";
            // 
            // tPesel
            // 
            this.tPesel.Location = new System.Drawing.Point(191, 143);
            this.tPesel.Name = "tPesel";
            this.tPesel.Size = new System.Drawing.Size(160, 20);
            this.tPesel.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Gender";
            // 
            // Lastname
            // 
            this.Lastname.AutoSize = true;
            this.Lastname.Location = new System.Drawing.Point(188, 77);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(49, 13);
            this.Lastname.TabIndex = 28;
            this.Lastname.Text = "Surname";
            // 
            // tSurname
            // 
            this.tSurname.Location = new System.Drawing.Point(191, 93);
            this.tSurname.Name = "tSurname";
            this.tSurname.Size = new System.Drawing.Size(160, 20);
            this.tSurname.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(53, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Fill in details about the student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(12, 93);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(152, 20);
            this.tName.TabIndex = 24;
            this.tName.TextChanged += new System.EventHandler(this.tName_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 40);
            this.button3.TabIndex = 37;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.saveClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(195, 240);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(156, 40);
            this.cancelButton.TabIndex = 38;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelClick);
            // 
            // tGender
            // 
            this.tGender.FormattingEnabled = true;
            this.tGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.tGender.Location = new System.Drawing.Point(12, 194);
            this.tGender.Name = "tGender";
            this.tGender.Size = new System.Drawing.Size(151, 21);
            this.tGender.TabIndex = 39;
            this.tGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // addStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 309);
            this.Controls.Add(this.tGender);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tParentsPhoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tPesel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.tSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tName);
            this.Name = "addStudent";
            this.Text = "addStudent";
            this.Load += new System.EventHandler(this.addStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tParentsPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tPesel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.TextBox tSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox tGender;
    }
}