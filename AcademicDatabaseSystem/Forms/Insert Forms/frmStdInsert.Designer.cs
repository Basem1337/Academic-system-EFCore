namespace WinFormsApp
{
    partial class frmStdInsert
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
            txtPhone = new TextBox();
            txtLName = new TextBox();
            txtFName = new TextBox();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(46, 64, 116);
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
            btnInsert.BackColor = Color.FromArgb(47, 82, 189);
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
            lblRowsMsg.ForeColor = Color.DodgerBlue;
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
            label5.Size = new Size(60, 26);
            label5.TabIndex = 32;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(51, 200);
            label6.Name = "label6";
            label6.Size = new Size(90, 26);
            label6.TabIndex = 33;
            label6.Text = "Last Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(51, 118);
            label7.Name = "label7";
            label7.Size = new Size(92, 26);
            label7.TabIndex = 34;
            label7.Text = "First Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkGray;
            label9.Location = new Point(56, 81);
            label9.Name = "label9";
            label9.Size = new Size(243, 23);
            label9.TabIndex = 30;
            label9.Text = "Please, Enter student data to insert.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Poppins SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(49, 31);
            label10.Name = "label10";
            label10.Size = new Size(224, 50);
            label10.TabIndex = 31;
            label10.Text = "Insert Student";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(56, 309);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(274, 27);
            txtPhone.TabIndex = 26;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(56, 229);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(274, 27);
            txtLName.TabIndex = 27;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(56, 147);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(274, 27);
            txtFName.TabIndex = 28;
            // 
            // frmStdInsert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 35, 47);
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtPhone);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(btnBack);
            Controls.Add(btnInsert);
            Controls.Add(lblRowsMsg);
            Name = "frmStdInsert";
            Text = "Insert Student";
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
        private TextBox txtPhone;
        private TextBox txtLName;
        private TextBox txtFName;
    }
}