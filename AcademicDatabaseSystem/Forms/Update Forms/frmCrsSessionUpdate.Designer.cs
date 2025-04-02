namespace WinFormsApp
{
    partial class frmCrsSessionUpdate
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
            txtTitle = new TextBox();
            txtCrsID = new TextBox();
            txtInstID = new TextBox();
            txtId = new TextBox();
            comboAll = new ComboBox();
            label5 = new Label();
            dgvAll = new DataGridView();
            separator = new GroupBox();
            txtDate = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAll).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(36, 358);
            label4.Name = "label4";
            label4.Size = new Size(42, 26);
            label4.TabIndex = 22;
            label4.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(36, 278);
            label3.Name = "label3";
            label3.Size = new Size(86, 26);
            label3.TabIndex = 23;
            label3.Text = "Course ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(36, 196);
            label2.Name = "label2";
            label2.Size = new Size(104, 26);
            label2.TabIndex = 24;
            label2.Text = "Instructor ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 121);
            label1.Name = "label1";
            label1.Size = new Size(27, 26);
            label1.TabIndex = 25;
            label1.Text = "ID";
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
            lblRowsMsg.Location = new Point(436, 337);
            lblRowsMsg.Name = "lblRowsMsg";
            lblRowsMsg.Size = new Size(104, 23);
            lblRowsMsg.TabIndex = 17;
            lblRowsMsg.Text = "1 Row Affected";
            // 
            // lblChoose
            // 
            lblChoose.AutoSize = true;
            lblChoose.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChoose.ForeColor = Color.DarkGray;
            lblChoose.Location = new Point(41, 86);
            lblChoose.Name = "lblChoose";
            lblChoose.Size = new Size(294, 23);
            lblChoose.TabIndex = 18;
            lblChoose.Text = "Please, Choose a course session to update.";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Poppins SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(34, 36);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(369, 50);
            lblWelcome.TabIndex = 19;
            lblWelcome.Text = "Update Course Sessions";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(41, 387);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(274, 27);
            txtTitle.TabIndex = 13;
            // 
            // txtCrsID
            // 
            txtCrsID.Location = new Point(41, 307);
            txtCrsID.Name = "txtCrsID";
            txtCrsID.Size = new Size(274, 27);
            txtCrsID.TabIndex = 14;
            // 
            // txtInstID
            // 
            txtInstID.Location = new Point(41, 225);
            txtInstID.Name = "txtInstID";
            txtInstID.Size = new Size(274, 27);
            txtInstID.TabIndex = 15;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(41, 150);
            txtId.Name = "txtId";
            txtId.Size = new Size(274, 27);
            txtId.TabIndex = 16;
            // 
            // comboAll
            // 
            comboAll.FormattingEnabled = true;
            comboAll.Location = new Point(441, 298);
            comboAll.Name = "comboAll";
            comboAll.Size = new Size(331, 28);
            comboAll.TabIndex = 26;
            comboAll.SelectedIndexChanged += comboStd_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(436, 269);
            label5.Name = "label5";
            label5.Size = new Size(178, 26);
            label5.TabIndex = 25;
            label5.Text = "Select Course Session";
            // 
            // dgvAll
            // 
            dgvAll.BackgroundColor = SystemColors.ControlLight;
            dgvAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAll.Dock = DockStyle.Bottom;
            dgvAll.Location = new Point(0, 457);
            dgvAll.Name = "dgvAll";
            dgvAll.RowHeadersWidth = 51;
            dgvAll.Size = new Size(800, 189);
            dgvAll.TabIndex = 27;
            // 
            // separator
            // 
            separator.Location = new Point(442, 250);
            separator.Name = "separator";
            separator.Size = new Size(330, 2);
            separator.TabIndex = 28;
            separator.TabStop = false;
            // 
            // txtDate
            // 
            txtDate.AllowDrop = true;
            txtDate.Location = new Point(442, 150);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(274, 27);
            txtDate.TabIndex = 13;
            // 
            // label6
            // 
            label6.AllowDrop = true;
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(437, 121);
            label6.Name = "label6";
            label6.Size = new Size(47, 26);
            label6.TabIndex = 22;
            label6.Text = "Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.IndianRed;
            label7.Location = new Point(133, 190);
            label7.Name = "label7";
            label7.Size = new Size(25, 36);
            label7.TabIndex = 37;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.IndianRed;
            label8.Location = new Point(115, 272);
            label8.Name = "label8";
            label8.Size = new Size(25, 36);
            label8.TabIndex = 38;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.IndianRed;
            label9.Location = new Point(478, 115);
            label9.Name = "label9";
            label9.Size = new Size(25, 36);
            label9.TabIndex = 39;
            label9.Text = "*";
            // 
            // frmCrsSessionUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 35, 47);
            ClientSize = new Size(800, 646);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(separator);
            Controls.Add(dgvAll);
            Controls.Add(comboAll);
            Controls.Add(label6);
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
            Controls.Add(txtDate);
            Controls.Add(txtTitle);
            Controls.Add(txtCrsID);
            Controls.Add(txtInstID);
            Controls.Add(txtId);
            Name = "frmCrsSessionUpdate";
            Text = "Update Course Session";
            Load += frmInstUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAll).EndInit();
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
        private TextBox txtTitle;
        private TextBox txtCrsID;
        private TextBox txtInstID;
        private TextBox txtId;
        private ComboBox comboAll;
        private Label label5;
        private DataGridView dgvAll;
        private GroupBox separator;
        private TextBox txtDate;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}