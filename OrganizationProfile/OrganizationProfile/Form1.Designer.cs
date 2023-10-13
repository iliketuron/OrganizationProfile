namespace OrganizationProfile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            datePickerBirthday = new DateTimePicker();
            label6 = new Label();
            cbPrograms = new ComboBox();
            label7 = new Label();
            txtFirstName = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 48);
            label1.Name = "label1";
            label1.Size = new Size(176, 41);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, 132);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 1;
            label2.Text = "Student No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 190);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(98, 246);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(67, 303);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 4;
            label5.Text = "Birthday";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(148, 130);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(200, 23);
            txtStudentNo.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(148, 192);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 6;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(148, 248);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(108, 23);
            txtAge.TabIndex = 7;
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Location = new Point(148, 303);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(247, 23);
            datePickerBirthday.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(435, 132);
            label6.Name = "label6";
            label6.Size = new Size(71, 21);
            label6.TabIndex = 9;
            label6.Text = "Program";
            // 
            // cbPrograms
            // 
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(512, 130);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(271, 23);
            cbPrograms.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(420, 188);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 11;
            label7.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(512, 192);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(134, 23);
            txtFirstName.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(652, 190);
            label8.Name = "label8";
            label8.Size = new Size(38, 21);
            label8.TabIndex = 13;
            label8.Text = "M. I.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(696, 192);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 450);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(txtFirstName);
            Controls.Add(label7);
            Controls.Add(cbPrograms);
            Controls.Add(label6);
            Controls.Add(datePickerBirthday);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtAge;
        private DateTimePicker datePickerBirthday;
        private Label label6;
        private ComboBox cbPrograms;
        private Label label7;
        private TextBox txtFirstName;
        private Label label8;
        private TextBox textBox1;
    }
}