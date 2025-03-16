namespace WinFormsApp
{
    partial class frmUpdate
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBack = new Button();
            btnUpdate = new Button();
            lblRowsMsg = new Label();
            lblChoose = new Label();
            lblWelcome = new Label();
            txtAddr = new TextBox();
            txtLName = new TextBox();
            txtFName = new TextBox();
            txtId = new TextBox();
            comboStd = new ComboBox();
            label5 = new Label();
            dgvStd = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStd).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(36, 358);
            label4.Name = "label4";
            label4.Size = new Size(73, 26);
            label4.TabIndex = 22;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(36, 278);
            label3.Name = "label3";
            label3.Size = new Size(90, 26);
            label3.TabIndex = 23;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(36, 196);
            label2.Name = "label2";
            label2.Size = new Size(92, 26);
            label2.TabIndex = 24;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 121);
            label1.Name = "label1";
            label1.Size = new Size(89, 26);
            label1.TabIndex = 25;
            label1.Text = "Student ID";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(46, 64, 116);
            btnBack.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(617, 367);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 47);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(47, 82, 189);
            btnUpdate.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(436, 367);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 47);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblRowsMsg
            // 
            lblRowsMsg.AutoSize = true;
            lblRowsMsg.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRowsMsg.ForeColor = Color.DodgerBlue;
            lblRowsMsg.Location = new Point(436, 330);
            lblRowsMsg.Name = "lblRowsMsg";
            lblRowsMsg.Size = new Size(13, 23);
            lblRowsMsg.TabIndex = 17;
            lblRowsMsg.Text = ".";
            // 
            // lblChoose
            // 
            lblChoose.AutoSize = true;
            lblChoose.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChoose.ForeColor = Color.DarkGray;
            lblChoose.Location = new Point(41, 86);
            lblChoose.Name = "lblChoose";
            lblChoose.Size = new Size(248, 23);
            lblChoose.TabIndex = 18;
            lblChoose.Text = "Please, Choose a student to update.";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Poppins SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(34, 36);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(299, 50);
            lblWelcome.TabIndex = 19;
            lblWelcome.Text = "\"Update\" Operation";
            // 
            // txtAddr
            // 
            txtAddr.Location = new Point(41, 387);
            txtAddr.Name = "txtAddr";
            txtAddr.Size = new Size(274, 27);
            txtAddr.TabIndex = 13;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(41, 307);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(274, 27);
            txtLName.TabIndex = 14;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(41, 225);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(274, 27);
            txtFName.TabIndex = 15;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(41, 150);
            txtId.Name = "txtId";
            txtId.Size = new Size(274, 27);
            txtId.TabIndex = 16;
            // 
            // comboStd
            // 
            comboStd.FormattingEnabled = true;
            comboStd.Location = new Point(436, 149);
            comboStd.Name = "comboStd";
            comboStd.Size = new Size(331, 28);
            comboStd.TabIndex = 26;
            comboStd.SelectedIndexChanged += comboStd_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(431, 120);
            label5.Name = "label5";
            label5.Size = new Size(119, 26);
            label5.TabIndex = 25;
            label5.Text = "Select Student";
            // 
            // dgvStd
            // 
            dgvStd.BackgroundColor = SystemColors.ControlLight;
            dgvStd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStd.Location = new Point(436, 183);
            dgvStd.Name = "dgvStd";
            dgvStd.RowHeadersWidth = 51;
            dgvStd.Size = new Size(331, 135);
            dgvStd.TabIndex = 27;
            // 
            // frmUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 35, 47);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvStd);
            Controls.Add(comboStd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(lblRowsMsg);
            Controls.Add(lblChoose);
            Controls.Add(lblWelcome);
            Controls.Add(txtAddr);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(txtId);
            Name = "frmUpdate";
            Text = "frmUpdate";
            ((System.ComponentModel.ISupportInitialize)dgvStd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBack;
        private Button btnUpdate;
        private Label lblRowsMsg;
        private Label lblChoose;
        private Label lblWelcome;
        private TextBox txtAddr;
        private TextBox txtLName;
        private TextBox txtFName;
        private TextBox txtId;
        private ComboBox comboStd;
        private Label label5;
        private DataGridView dgvStd;
    }
}