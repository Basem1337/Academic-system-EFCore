namespace WinFormsApp
{
    partial class frmCrsSessionAttInsert
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
            txtStdID = new TextBox();
            txtCrsSID = new TextBox();
            txtNotes = new TextBox();
            txtGrade = new TextBox();
            label3 = new Label();
            label1 = new Label();
            comboStd = new ComboBox();
            comboCrsSession = new ComboBox();
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
            label5.Size = new Size(89, 26);
            label5.TabIndex = 32;
            label5.Text = "Student ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(51, 273);
            label6.Name = "label6";
            label6.Size = new Size(148, 26);
            label6.TabIndex = 33;
            label6.Text = "Course Session ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(51, 191);
            label7.Name = "label7";
            label7.Size = new Size(55, 26);
            label7.TabIndex = 34;
            label7.Text = "Notes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(52, 116);
            label8.Name = "label8";
            label8.Size = new Size(59, 26);
            label8.TabIndex = 35;
            label8.Text = "Grade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkGray;
            label9.Location = new Point(56, 81);
            label9.Name = "label9";
            label9.Size = new Size(318, 23);
            label9.TabIndex = 30;
            label9.Text = "Please, Enter course attendance data to insert.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Poppins SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(49, 31);
            label10.Name = "label10";
            label10.Size = new Size(507, 50);
            label10.TabIndex = 31;
            label10.Text = "Insert Course Session Attendance";
            // 
            // txtStdID
            // 
            txtStdID.Location = new Point(587, 194);
            txtStdID.Name = "txtStdID";
            txtStdID.Size = new Size(274, 27);
            txtStdID.TabIndex = 26;
            // 
            // txtCrsSID
            // 
            txtCrsSID.Location = new Point(587, 114);
            txtCrsSID.Name = "txtCrsSID";
            txtCrsSID.Size = new Size(274, 27);
            txtCrsSID.TabIndex = 27;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(56, 220);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(274, 27);
            txtNotes.TabIndex = 28;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(56, 145);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(274, 27);
            txtGrade.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(191, 267);
            label3.Name = "label3";
            label3.Size = new Size(25, 36);
            label3.TabIndex = 36;
            label3.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(134, 347);
            label1.Name = "label1";
            label1.Size = new Size(25, 36);
            label1.TabIndex = 36;
            label1.Text = "*";
            // 
            // comboStd
            // 
            comboStd.FormattingEnabled = true;
            comboStd.Location = new Point(56, 381);
            comboStd.Name = "comboStd";
            comboStd.Size = new Size(275, 28);
            comboStd.TabIndex = 54;
            // 
            // comboCrsSession
            // 
            comboCrsSession.FormattingEnabled = true;
            comboCrsSession.Location = new Point(56, 301);
            comboCrsSession.Name = "comboCrsSession";
            comboCrsSession.Size = new Size(275, 28);
            comboCrsSession.TabIndex = 55;
            // 
            // frmCrsSessionAttInsert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 49, 49);
            ClientSize = new Size(800, 450);
            Controls.Add(comboStd);
            Controls.Add(comboCrsSession);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtStdID);
            Controls.Add(txtCrsSID);
            Controls.Add(txtNotes);
            Controls.Add(txtGrade);
            Controls.Add(btnBack);
            Controls.Add(btnInsert);
            Controls.Add(lblRowsMsg);
            Name = "frmCrsSessionAttInsert";
            Text = "Insert Course Session Attendance";
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
        private TextBox txtStdID;
        private TextBox txtCrsSID;
        private TextBox txtNotes;
        private TextBox txtGrade;
        private Label label3;
        private Label label1;
        private ComboBox comboStd;
        private ComboBox comboCrsSession;
    }
}