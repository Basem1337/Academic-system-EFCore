namespace WinFormsApp
{
    partial class frmInsert
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
            txtId = new TextBox();
            lblChoose = new Label();
            lblWelcome = new Label();
            txtFName = new TextBox();
            txtLName = new TextBox();
            TxtAddr = new TextBox();
            btnBack = new Button();
            btnInsert = new Button();
            lblRowsMsg = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(43, 145);
            txtId.Name = "txtId";
            txtId.Size = new Size(274, 27);
            txtId.TabIndex = 1;
            // 
            // lblChoose
            // 
            lblChoose.AutoSize = true;
            lblChoose.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChoose.ForeColor = Color.DarkGray;
            lblChoose.Location = new Point(43, 81);
            lblChoose.Name = "lblChoose";
            lblChoose.Size = new Size(166, 23);
            lblChoose.TabIndex = 8;
            lblChoose.Text = "Please, Insert a student.";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Poppins SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(36, 31);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(275, 50);
            lblWelcome.TabIndex = 9;
            lblWelcome.Text = "\"Insert\" Operation";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(43, 220);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(274, 27);
            txtFName.TabIndex = 1;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(43, 302);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(274, 27);
            txtLName.TabIndex = 1;
            // 
            // TxtAddr
            // 
            TxtAddr.Location = new Point(43, 382);
            TxtAddr.Name = "TxtAddr";
            TxtAddr.Size = new Size(274, 27);
            TxtAddr.TabIndex = 1;
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
            lblRowsMsg.Size = new Size(13, 23);
            lblRowsMsg.TabIndex = 8;
            lblRowsMsg.Text = ".";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 116);
            label1.Name = "label1";
            label1.Size = new Size(89, 26);
            label1.TabIndex = 12;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(38, 191);
            label2.Name = "label2";
            label2.Size = new Size(92, 26);
            label2.TabIndex = 12;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(38, 273);
            label3.Name = "label3";
            label3.Size = new Size(90, 26);
            label3.TabIndex = 12;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(38, 353);
            label4.Name = "label4";
            label4.Size = new Size(73, 26);
            label4.TabIndex = 12;
            label4.Text = "Address";
            // 
            // frmInsert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 35, 47);
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnInsert);
            Controls.Add(lblRowsMsg);
            Controls.Add(lblChoose);
            Controls.Add(lblWelcome);
            Controls.Add(TxtAddr);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(txtId);
            Name = "frmInsert";
            Text = "Insert Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtId;
        private Label lblChoose;
        private Label lblWelcome;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox TxtAddr;
        private Button btnBack;
        private Button btnInsert;
        private Label lblRowsMsg;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}