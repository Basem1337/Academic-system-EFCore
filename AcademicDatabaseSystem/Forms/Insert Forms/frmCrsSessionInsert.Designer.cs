﻿namespace WinFormsApp
{
    partial class frmCrsSessionInsert
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
            txtDate = new TextBox();
            txtTitle = new TextBox();
            txtInsID = new TextBox();
            txtCrsID = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            lblDate = new Label();
            lblInsID = new Label();
            lblCrsID = new Label();
            comboCrs = new ComboBox();
            comboInst = new ComboBox();
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
            label5.Size = new Size(47, 26);
            label5.TabIndex = 32;
            label5.Text = "Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(51, 273);
            label6.Name = "label6";
            label6.Size = new Size(42, 26);
            label6.TabIndex = 33;
            label6.Text = "Title";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(51, 191);
            label7.Name = "label7";
            label7.Size = new Size(104, 26);
            label7.TabIndex = 34;
            label7.Text = "Instructor ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(52, 116);
            label8.Name = "label8";
            label8.Size = new Size(86, 26);
            label8.TabIndex = 35;
            label8.Text = "Course ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkGray;
            label9.Location = new Point(56, 81);
            label9.Name = "label9";
            label9.Size = new Size(289, 23);
            label9.TabIndex = 30;
            label9.Text = "Please, Enter course session data to insert.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Poppins SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(49, 31);
            label10.Name = "label10";
            label10.Size = new Size(330, 50);
            label10.TabIndex = 31;
            label10.Text = "Insert Course Session";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(56, 382);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(274, 27);
            txtDate.TabIndex = 26;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(56, 302);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(274, 27);
            txtTitle.TabIndex = 27;
            // 
            // txtInsID
            // 
            txtInsID.Location = new Point(590, 193);
            txtInsID.Name = "txtInsID";
            txtInsID.Size = new Size(274, 27);
            txtInsID.TabIndex = 28;
            // 
            // txtCrsID
            // 
            txtCrsID.Location = new Point(590, 118);
            txtCrsID.Name = "txtCrsID";
            txtCrsID.Size = new Size(274, 27);
            txtCrsID.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(130, 110);
            label3.Name = "label3";
            label3.Size = new Size(25, 36);
            label3.TabIndex = 37;
            label3.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(147, 185);
            label1.Name = "label1";
            label1.Size = new Size(25, 36);
            label1.TabIndex = 37;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(92, 347);
            label2.Name = "label2";
            label2.Size = new Size(25, 36);
            label2.TabIndex = 37;
            label2.Text = "*";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.IndianRed;
            lblDate.Location = new Point(56, 408);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(287, 23);
            lblDate.TabIndex = 46;
            lblDate.Text = "Date must be like this format mm/dd/yyyy";
            // 
            // lblInsID
            // 
            lblInsID.AutoSize = true;
            lblInsID.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInsID.ForeColor = Color.IndianRed;
            lblInsID.Location = new Point(590, 219);
            lblInsID.Name = "lblInsID";
            lblInsID.Size = new Size(214, 23);
            lblInsID.TabIndex = 46;
            lblInsID.Text = "Instructor ID must be a number";
            // 
            // lblCrsID
            // 
            lblCrsID.AutoSize = true;
            lblCrsID.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCrsID.ForeColor = Color.IndianRed;
            lblCrsID.Location = new Point(590, 144);
            lblCrsID.Name = "lblCrsID";
            lblCrsID.Size = new Size(198, 23);
            lblCrsID.TabIndex = 46;
            lblCrsID.Text = "Course ID must be a number";
            // 
            // comboCrs
            // 
            comboCrs.FormattingEnabled = true;
            comboCrs.Location = new Point(56, 142);
            comboCrs.Name = "comboCrs";
            comboCrs.Size = new Size(275, 28);
            comboCrs.TabIndex = 52;
            // 
            // comboInst
            // 
            comboInst.FormattingEnabled = true;
            comboInst.Location = new Point(56, 224);
            comboInst.Name = "comboInst";
            comboInst.Size = new Size(275, 28);
            comboInst.TabIndex = 53;
            // 
            // frmCrsSessionInsert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 49, 49);
            ClientSize = new Size(800, 450);
            Controls.Add(comboCrs);
            Controls.Add(comboInst);
            Controls.Add(lblCrsID);
            Controls.Add(lblInsID);
            Controls.Add(lblDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtDate);
            Controls.Add(txtTitle);
            Controls.Add(txtInsID);
            Controls.Add(txtCrsID);
            Controls.Add(btnBack);
            Controls.Add(btnInsert);
            Controls.Add(lblRowsMsg);
            Name = "frmCrsSessionInsert";
            Text = "Insert Course Session";
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
        private TextBox txtDate;
        private TextBox txtTitle;
        private TextBox txtInsID;
        private TextBox txtCrsID;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label lblDate;
        private Label lblInsID;
        private Label lblCrsID;
        private ComboBox comboCrs;
        private ComboBox comboInst;
    }
}