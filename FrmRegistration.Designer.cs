namespace AccountRegistration
{
    partial class FrmRegistration
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
            txtStudentNo = new TextBox();
            btnNext = new Button();
            cmbProgram = new ComboBox();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtContact = new TextBox();
            txtAge = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtAddress = new TextBox();
            label9 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(59, 123);
            label1.Name = "label1";
            label1.Size = new Size(94, 19);
            label1.TabIndex = 0;
            label1.Text = "Student No.";
            // 
            // txtStudentNo
            // 
            txtStudentNo.BorderStyle = BorderStyle.FixedSingle;
            txtStudentNo.Location = new Point(59, 147);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(377, 27);
            txtStudentNo.TabIndex = 1;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.LightSkyBlue;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(420, 525);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(118, 38);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // cmbProgram
            // 
            cmbProgram.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Location = new Point(442, 144);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(440, 30);
            cmbProgram.TabIndex = 3;
            cmbProgram.DropDown += FrmRegistration_Load;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(-1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 80);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Castellar", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(181, 22);
            label2.Name = "label2";
            label2.Size = new Size(589, 48);
            label2.TabIndex = 6;
            label2.Text = "Student Registration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(442, 122);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 6;
            label3.Text = "Program";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(59, 207);
            label4.Name = "label4";
            label4.Size = new Size(86, 19);
            label4.TabIndex = 7;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(338, 207);
            label5.Name = "label5";
            label5.Size = new Size(88, 19);
            label5.TabIndex = 8;
            label5.Text = "First Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(617, 207);
            label6.Name = "label6";
            label6.Size = new Size(103, 19);
            label6.TabIndex = 9;
            label6.Text = "Middle Name";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(59, 229);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(273, 27);
            txtLastName.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(338, 229);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(273, 27);
            txtFirstName.TabIndex = 11;
            // 
            // txtMiddleName
            // 
            txtMiddleName.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleName.Location = new Point(617, 229);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(273, 27);
            txtMiddleName.TabIndex = 12;
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Location = new Point(338, 316);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(273, 27);
            txtContact.TabIndex = 16;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Location = new Point(59, 316);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(273, 27);
            txtAge.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(338, 294);
            label7.Name = "label7";
            label7.Size = new Size(95, 19);
            label7.TabIndex = 14;
            label7.Text = "Contact No.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(59, 294);
            label8.Name = "label8";
            label8.Size = new Size(38, 19);
            label8.TabIndex = 13;
            label8.Text = "Age";
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(59, 408);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(831, 88);
            txtAddress.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(59, 386);
            label9.Name = "label9";
            label9.Size = new Size(69, 19);
            label9.TabIndex = 17;
            label9.Text = "Address";
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(952, 592);
            Controls.Add(txtAddress);
            Controls.Add(label9);
            Controls.Add(txtContact);
            Controls.Add(txtAge);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(cmbProgram);
            Controls.Add(btnNext);
            Controls.Add(txtStudentNo);
            Controls.Add(label1);
            Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Name = "FrmRegistration";
            Text = "FrmRegistration";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStudentNo;
        private Button btnNext;
        private ComboBox cmbProgram;
       
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtContact;
        private TextBox txtAge;
        private Label label7;
        private Label label8;
        private TextBox txtAddress;
        private Label label9;
       
    }
}
