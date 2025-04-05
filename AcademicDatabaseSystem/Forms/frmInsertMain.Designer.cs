namespace AcademicDatabaseSystem.Forms
{
    partial class frmInsertMain
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
            lblChoose = new Label();
            lblWelcome = new Label();
            btnBack = new Button();
            btnCrsUpdate = new Button();
            btnDeptUpdate = new Button();
            btnInstUpdate = new Button();
            btnStdUpdate = new Button();
            btnCSUpdate = new Button();
            btnCSAUpdate = new Button();
            SuspendLayout();
            // 
            // lblChoose
            // 
            lblChoose.AutoSize = true;
            lblChoose.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChoose.ForeColor = Color.DarkGray;
            lblChoose.Location = new Point(40, 86);
            lblChoose.Name = "lblChoose";
            lblChoose.Size = new Size(324, 23);
            lblChoose.TabIndex = 3;
            lblChoose.Text = "Please, Choose the table you want to insert into.";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Poppins SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(33, 36);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(103, 50);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "Insert";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(85, 134, 140);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(40, 353);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(182, 47);
            btnBack.TabIndex = 22;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnCrsUpdate
            // 
            btnCrsUpdate.BackColor = Color.FromArgb(68, 187, 164);
            btnCrsUpdate.FlatStyle = FlatStyle.Popup;
            btnCrsUpdate.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrsUpdate.ForeColor = Color.White;
            btnCrsUpdate.Location = new Point(40, 214);
            btnCrsUpdate.Name = "btnCrsUpdate";
            btnCrsUpdate.Size = new Size(182, 56);
            btnCrsUpdate.TabIndex = 23;
            btnCrsUpdate.Text = "Courses";
            btnCrsUpdate.UseVisualStyleBackColor = false;
            btnCrsUpdate.Click += btnCrsUpdate_Click;
            // 
            // btnDeptUpdate
            // 
            btnDeptUpdate.BackColor = Color.FromArgb(68, 187, 164);
            btnDeptUpdate.FlatStyle = FlatStyle.Popup;
            btnDeptUpdate.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeptUpdate.ForeColor = Color.White;
            btnDeptUpdate.Location = new Point(442, 139);
            btnDeptUpdate.Name = "btnDeptUpdate";
            btnDeptUpdate.Size = new Size(182, 56);
            btnDeptUpdate.TabIndex = 24;
            btnDeptUpdate.Text = "Departments";
            btnDeptUpdate.UseVisualStyleBackColor = false;
            btnDeptUpdate.Click += btnDeptUpdate_Click;
            // 
            // btnInstUpdate
            // 
            btnInstUpdate.BackColor = Color.FromArgb(68, 187, 164);
            btnInstUpdate.FlatStyle = FlatStyle.Popup;
            btnInstUpdate.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInstUpdate.ForeColor = Color.White;
            btnInstUpdate.Location = new Point(241, 139);
            btnInstUpdate.Name = "btnInstUpdate";
            btnInstUpdate.Size = new Size(182, 56);
            btnInstUpdate.TabIndex = 25;
            btnInstUpdate.Text = "Instructors";
            btnInstUpdate.UseVisualStyleBackColor = false;
            btnInstUpdate.Click += btnInstUpdate_Click;
            // 
            // btnStdUpdate
            // 
            btnStdUpdate.BackColor = Color.FromArgb(68, 187, 164);
            btnStdUpdate.FlatStyle = FlatStyle.Popup;
            btnStdUpdate.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStdUpdate.ForeColor = Color.White;
            btnStdUpdate.Location = new Point(40, 139);
            btnStdUpdate.Name = "btnStdUpdate";
            btnStdUpdate.Size = new Size(182, 56);
            btnStdUpdate.TabIndex = 26;
            btnStdUpdate.Text = "Students";
            btnStdUpdate.UseVisualStyleBackColor = false;
            btnStdUpdate.Click += btnStdUpdate_Click;
            // 
            // btnCSUpdate
            // 
            btnCSUpdate.BackColor = Color.FromArgb(68, 187, 164);
            btnCSUpdate.FlatStyle = FlatStyle.Popup;
            btnCSUpdate.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            btnCSUpdate.ForeColor = Color.White;
            btnCSUpdate.Location = new Point(241, 214);
            btnCSUpdate.Name = "btnCSUpdate";
            btnCSUpdate.Size = new Size(182, 56);
            btnCSUpdate.TabIndex = 26;
            btnCSUpdate.Text = "Course Sessions";
            btnCSUpdate.UseVisualStyleBackColor = false;
            btnCSUpdate.Click += btnCSUpdate_Click;
            // 
            // btnCSAUpdate
            // 
            btnCSAUpdate.BackColor = Color.FromArgb(68, 187, 164);
            btnCSAUpdate.FlatStyle = FlatStyle.Popup;
            btnCSAUpdate.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            btnCSAUpdate.ForeColor = Color.White;
            btnCSAUpdate.Location = new Point(442, 214);
            btnCSAUpdate.Name = "btnCSAUpdate";
            btnCSAUpdate.Size = new Size(182, 56);
            btnCSAUpdate.TabIndex = 26;
            btnCSAUpdate.Text = "Course Attends";
            btnCSAUpdate.UseVisualStyleBackColor = false;
            btnCSAUpdate.Click += btnCSAUpdate_Click;
            // 
            // frmInsertMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 49, 49);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCrsUpdate);
            Controls.Add(btnDeptUpdate);
            Controls.Add(btnInstUpdate);
            Controls.Add(btnCSAUpdate);
            Controls.Add(btnCSUpdate);
            Controls.Add(btnStdUpdate);
            Controls.Add(btnBack);
            Controls.Add(lblChoose);
            Controls.Add(lblWelcome);
            Name = "frmInsertMain";
            Text = "Update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblChoose;
        private Label lblWelcome;
        private Button btnBack;
        private Button btnCrsUpdate;
        private Button btnDeptUpdate;
        private Button btnInstUpdate;
        private Button btnStdUpdate;
        private Button btnCSUpdate;
        private Button btnCSAUpdate;
    }
}