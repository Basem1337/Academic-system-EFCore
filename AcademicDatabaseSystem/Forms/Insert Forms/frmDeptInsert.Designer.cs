﻿namespace WinFormsApp
{
    partial class frmDeptInsert
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
            label9 = new Label();
            label10 = new Label();
            txtManagerID = new TextBox();
            txtLocation = new TextBox();
            txtDeptName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            lblMng = new Label();
            lblDeptName = new Label();
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
            label5.Location = new Point(51, 280);
            label5.Name = "label5";
            label5.Size = new Size(99, 26);
            label5.TabIndex = 32;
            label5.Text = "Manager ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(51, 200);
            label6.Name = "label6";
            label6.Size = new Size(170, 26);
            label6.TabIndex = 33;
            label6.Text = "Department Location";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(51, 118);
            label7.Name = "label7";
            label7.Size = new Size(151, 26);
            label7.TabIndex = 34;
            label7.Text = "Department Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkGray;
            label9.Location = new Point(56, 81);
            label9.Name = "label9";
            label9.Size = new Size(272, 23);
            label9.TabIndex = 30;
            label9.Text = "Please, Enter department data to insert.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Poppins SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(49, 31);
            label10.Name = "label10";
            label10.Size = new Size(284, 50);
            label10.TabIndex = 31;
            label10.Text = "Insert Department";
            // 
            // txtManagerID
            // 
            txtManagerID.Location = new Point(56, 309);
            txtManagerID.Name = "txtManagerID";
            txtManagerID.Size = new Size(274, 27);
            txtManagerID.TabIndex = 26;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(56, 229);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(274, 27);
            txtLocation.TabIndex = 27;
            // 
            // txtDeptName
            // 
            txtDeptName.Location = new Point(56, 147);
            txtDeptName.Name = "txtDeptName";
            txtDeptName.Size = new Size(274, 27);
            txtDeptName.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(196, 112);
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
            label1.Location = new Point(144, 274);
            label1.Name = "label1";
            label1.Size = new Size(25, 36);
            label1.TabIndex = 37;
            label1.Text = "*";
            // 
            // lblMng
            // 
            lblMng.AutoSize = true;
            lblMng.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMng.ForeColor = Color.IndianRed;
            lblMng.Location = new Point(56, 337);
            lblMng.Name = "lblMng";
            lblMng.Size = new Size(241, 23);
            lblMng.TabIndex = 45;
            lblMng.Text = "Manager ID must be a number only";
            // 
            // lblDeptName
            // 
            lblDeptName.AutoSize = true;
            lblDeptName.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeptName.ForeColor = Color.IndianRed;
            lblDeptName.Location = new Point(56, 174);
            lblDeptName.Name = "lblDeptName";
            lblDeptName.Size = new Size(299, 23);
            lblDeptName.TabIndex = 46;
            lblDeptName.Text = "Department Name must be characters only.";
            // 
            // frmDeptInsert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 49, 49);
            ClientSize = new Size(800, 450);
            Controls.Add(lblMng);
            Controls.Add(lblDeptName);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtManagerID);
            Controls.Add(txtLocation);
            Controls.Add(txtDeptName);
            Controls.Add(btnBack);
            Controls.Add(btnInsert);
            Controls.Add(lblRowsMsg);
            Name = "frmDeptInsert";
            Text = "Insert Department";
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
        private Label label9;
        private Label label10;
        private TextBox txtManagerID;
        private TextBox txtLocation;
        private TextBox txtDeptName;
        private Label label3;
        private Label label1;
        private Label lblMng;
        private Label lblDeptName;
    }
}