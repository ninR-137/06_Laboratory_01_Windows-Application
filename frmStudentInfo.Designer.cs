namespace StudentInfoApplication
{
    partial class frmStudentInfo
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
            studentId = new TextBox();
            lastName = new TextBox();
            firstName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            studentIdList = new ListBox();
            firstNameList = new ListBox();
            lastNameList = new ListBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            submit = new Button();
            SuspendLayout();
            // 
            // studentId
            // 
            studentId.Location = new Point(12, 60);
            studentId.Name = "studentId";
            studentId.Size = new Size(169, 23);
            studentId.TabIndex = 0;
            // 
            // lastName
            // 
            lastName.Location = new Point(236, 60);
            lastName.Name = "lastName";
            lastName.Size = new Size(169, 23);
            lastName.TabIndex = 1;
            // 
            // firstName
            // 
            firstName.Location = new Point(464, 60);
            firstName.Name = "firstName";
            firstName.Size = new Size(169, 23);
            firstName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 3;
            label1.Text = "Student ID*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 32);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 4;
            label2.Text = "Last Name*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(464, 32);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = "First Name*";
            // 
            // studentIdList
            // 
            studentIdList.FormattingEnabled = true;
            studentIdList.HorizontalScrollbar = true;
            studentIdList.ItemHeight = 15;
            studentIdList.Location = new Point(12, 219);
            studentIdList.Name = "studentIdList";
            studentIdList.Size = new Size(166, 139);
            studentIdList.TabIndex = 6;
            // 
            // firstNameList
            // 
            firstNameList.FormattingEnabled = true;
            firstNameList.HorizontalScrollbar = true;
            firstNameList.ItemHeight = 15;
            firstNameList.Location = new Point(236, 219);
            firstNameList.Name = "firstNameList";
            firstNameList.Size = new Size(166, 139);
            firstNameList.TabIndex = 7;
            // 
            // lastNameList
            // 
            lastNameList.FormattingEnabled = true;
            lastNameList.HorizontalScrollbar = true;
            lastNameList.ItemHeight = 15;
            lastNameList.Location = new Point(464, 219);
            lastNameList.Name = "lastNameList";
            lastNameList.Size = new Size(166, 139);
            lastNameList.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 192);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 9;
            label4.Text = "Student Id List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(236, 192);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 10;
            label5.Text = "First Name List";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(464, 192);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 11;
            label6.Text = "Last Name List";
            // 
            // submit
            // 
            submit.Location = new Point(555, 135);
            submit.Name = "submit";
            submit.Size = new Size(75, 23);
            submit.TabIndex = 12;
            submit.Text = "submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // frmStudentInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 401);
            Controls.Add(submit);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lastNameList);
            Controls.Add(firstNameList);
            Controls.Add(studentIdList);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(firstName);
            Controls.Add(lastName);
            Controls.Add(studentId);
            Name = "frmStudentInfo";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox studentId;
        private TextBox lastName;
        private TextBox firstName;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox studentIdList;
        private ListBox firstNameList;
        private ListBox lastNameList;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button submit;
    }
}
