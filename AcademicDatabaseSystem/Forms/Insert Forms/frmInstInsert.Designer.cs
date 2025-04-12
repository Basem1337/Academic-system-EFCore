namespace WinFormsApp
{
    partial class frmInstInsert
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
            btnBack = new Button();
            btnInsert = new Button();
            lblRowsMsg = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtPhone = new TextBox();
            txtSalary = new TextBox();
            txtLName = new TextBox();
            txtFName = new TextBox();
            txtDeptID = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            lblSalary = new Label();
            lblPhone = new Label();
            lblLname = new Label();
            lblFname = new Label();
            lblDeptID = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(85, 134, 140);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(619, 362);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 47);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(68, 187, 164);
            btnInsert.FlatStyle = FlatStyle.Popup;
            btnInsert.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(438, 362);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(150, 47);
            btnInsert.TabIndex = 11;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // lblRowsMsg
            // 
            lblRowsMsg.AutoSize = true;
            lblRowsMsg.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRowsMsg.ForeColor = Color.FromArgb(68, 187, 164);
            lblRowsMsg.Location = new Point(438, 306);
            lblRowsMsg.Name = "lblRowsMsg";
            lblRowsMsg.Size = new Size(176, 23);
            lblRowsMsg.TabIndex = 8;
            lblRowsMsg.Text = "1 Row Added Successfully";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(51, 353);
            label5.Name = "label5";
            label5.Size = new Size(60, 26);
            label5.TabIndex = 32;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(51, 273);
            label6.Name = "label6";
            label6.Size = new Size(59, 26);
            label6.TabIndex = 33;
            label6.Text = "Salary";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(51, 191);
            label7.Name = "label7";
            label7.Size = new Size(90, 26);
            label7.TabIndex = 34;
            label7.Text = "Last Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(52, 116);
            label8.Name = "label8";
            label8.Size = new Size(92, 26);
            label8.TabIndex = 35;
            label8.Text = "First Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkGray;
            label9.Location = new Point(56, 81);
            label9.Name = "label9";
            label9.Size = new Size(255, 23);
            label9.TabIndex = 30;
            label9.Text = "Please, Enter instructor data to insert.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Poppins SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(49, 31);
            label10.Name = "label10";
            label10.Size = new Size(251, 50);
            label10.TabIndex = 31;
            label10.Text = "Insert Instructor";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(56, 382);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(274, 27);
            txtPhone.TabIndex = 26;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(56, 302);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(274, 27);
            txtSalary.TabIndex = 27;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(56, 220);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(274, 27);
            txtLName.TabIndex = 28;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(56, 145);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(274, 27);
            txtFName.TabIndex = 29;
            // 
            // txtDeptID
            // 
            txtDeptID.Enabled = false;
            txtDeptID.Location = new Point(438, 145);
            txtDeptID.Name = "txtDeptID";
            txtDeptID.Size = new Size(274, 27);
            txtDeptID.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(434, 116);
            label1.Name = "label1";
            label1.Size = new Size(121, 26);
            label1.TabIndex = 35;
            label1.Text = "Department ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(137, 110);
            label3.Name = "label3";
            label3.Size = new Size(25, 36);
            label3.TabIndex = 37;
            label3.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(137, 185);
            label2.Name = "label2";
            label2.Size = new Size(25, 36);
            label2.TabIndex = 37;
            label2.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.IndianRed;
            label4.Location = new Point(547, 110);
            label4.Name = "label4";
            label4.Size = new Size(25, 36);
            label4.TabIndex = 37;
            label4.Text = "*";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalary.ForeColor = Color.IndianRed;
            lblSalary.Location = new Point(56, 330);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(186, 23);
            lblSalary.TabIndex = 42;
            lblSalary.Text = "Salary must a number only";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.IndianRed;
            lblPhone.Location = new Point(56, 412);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(255, 23);
            lblPhone.TabIndex = 43;
            lblPhone.Text = "Phone must be 11 numbers (Egyptian)";
            // 
            // lblLname
            // 
            lblLname.AutoSize = true;
            lblLname.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLname.ForeColor = Color.IndianRed;
            lblLname.Location = new Point(56, 247);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(216, 23);
            lblLname.TabIndex = 44;
            lblLname.Text = "Name must be characters only.";
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFname.ForeColor = Color.IndianRed;
            lblFname.Location = new Point(56, 171);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(216, 23);
            lblFname.TabIndex = 45;
            lblFname.Text = "Name must be characters only.";
            // 
            // lblDeptID
            // 
            lblDeptID.AutoSize = true;
            lblDeptID.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeptID.ForeColor = Color.IndianRed;
            lblDeptID.Location = new Point(438, 175);
            lblDeptID.Name = "lblDeptID";
            lblDeptID.Size = new Size(240, 23);
            lblDeptID.TabIndex = 46;
            lblDeptID.Text = "Department ID must a number only";
            // 
            // frmInstInsert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 49, 49);
            ClientSize = new Size(800, 450);
            Controls.Add(lblDeptID);
            Controls.Add(lblSalary);
            Controls.Add(lblPhone);
            Controls.Add(lblLname);
            Controls.Add(lblFname);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtPhone);
            Controls.Add(txtSalary);
            Controls.Add(txtLName);
            Controls.Add(txtDeptID);
            Controls.Add(txtFName);
            Controls.Add(btnBack);
            Controls.Add(btnInsert);
            Controls.Add(lblRowsMsg);
            Name = "frmInstInsert";
            Text = "Insert Instructor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBack;
        private Button btnInsert;
        private Label lblRowsMsg;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtPhone;
        private TextBox txtSalary;
        private TextBox txtLName;
        private TextBox txtFName;
        private TextBox txtDeptID;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label lblSalary;
        private Label lblPhone;
        private Label lblLname;
        private Label lblFname;
        private Label lblDeptID;
    }
}