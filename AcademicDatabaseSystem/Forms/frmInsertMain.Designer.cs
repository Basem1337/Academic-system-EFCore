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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertMain));
            picIntro = new PictureBox();
            lblChoose = new Label();
            lblWelcome = new Label();
            btnBack = new Button();
            btnCrsUpdate = new Button();
            btnDeptUpdate = new Button();
            btnInstUpdate = new Button();
            btnStdUpdate = new Button();
            btnCSUpdate = new Button();
            btnCSAUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)picIntro).BeginInit();
            SuspendLayout();
            // 
            // picIntro
            // 
            picIntro.Dock = DockStyle.Right;
            picIntro.Image = (Image)resources.GetObject("picIntro.Image");
            picIntro.ImageLocation = "";
            picIntro.Location = new Point(487, 0);
            picIntro.Name = "picIntro";
            picIntro.Size = new Size(313, 450);
            picIntro.SizeMode = PictureBoxSizeMode.StretchImage;
            picIntro.TabIndex = 5;
            picIntro.TabStop = false;
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
            btnBack.BackColor = Color.FromArgb(46, 64, 116);
            btnBack.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(241, 365);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 47);
            btnBack.TabIndex = 22;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnCrsUpdate
            // 
            btnCrsUpdate.BackColor = Color.FromArgb(47, 82, 189);
            btnCrsUpdate.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrsUpdate.ForeColor = Color.White;
            btnCrsUpdate.Location = new Point(40, 365);
            btnCrsUpdate.Name = "btnCrsUpdate";
            btnCrsUpdate.Size = new Size(150, 47);
            btnCrsUpdate.TabIndex = 23;
            btnCrsUpdate.Text = "Courses";
            btnCrsUpdate.UseVisualStyleBackColor = false;
            btnCrsUpdate.Click += btnCrsUpdate_Click;
            // 
            // btnDeptUpdate
            // 
            btnDeptUpdate.BackColor = Color.FromArgb(47, 82, 189);
            btnDeptUpdate.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeptUpdate.ForeColor = Color.White;
            btnDeptUpdate.Location = new Point(40, 288);
            btnDeptUpdate.Name = "btnDeptUpdate";
            btnDeptUpdate.Size = new Size(150, 47);
            btnDeptUpdate.TabIndex = 24;
            btnDeptUpdate.Text = "Departments";
            btnDeptUpdate.UseVisualStyleBackColor = false;
            btnDeptUpdate.Click += btnDeptUpdate_Click;
            // 
            // btnInstUpdate
            // 
            btnInstUpdate.BackColor = Color.FromArgb(47, 82, 189);
            btnInstUpdate.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInstUpdate.ForeColor = Color.White;
            btnInstUpdate.Location = new Point(40, 214);
            btnInstUpdate.Name = "btnInstUpdate";
            btnInstUpdate.Size = new Size(150, 47);
            btnInstUpdate.TabIndex = 25;
            btnInstUpdate.Text = "Instructors";
            btnInstUpdate.UseVisualStyleBackColor = false;
            btnInstUpdate.Click += btnInstUpdate_Click;
            // 
            // btnStdUpdate
            // 
            btnStdUpdate.BackColor = Color.FromArgb(47, 82, 189);
            btnStdUpdate.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStdUpdate.ForeColor = Color.White;
            btnStdUpdate.Location = new Point(40, 139);
            btnStdUpdate.Name = "btnStdUpdate";
            btnStdUpdate.Size = new Size(150, 47);
            btnStdUpdate.TabIndex = 26;
            btnStdUpdate.Text = "Students";
            btnStdUpdate.UseVisualStyleBackColor = false;
            btnStdUpdate.Click += btnStdUpdate_Click;
            // 
            // btnCSUpdate
            // 
            btnCSUpdate.BackColor = Color.FromArgb(47, 82, 189);
            btnCSUpdate.Font = new Font("Poppins", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCSUpdate.ForeColor = Color.White;
            btnCSUpdate.Location = new Point(241, 139);
            btnCSUpdate.Name = "btnCSUpdate";
            btnCSUpdate.Size = new Size(150, 47);
            btnCSUpdate.TabIndex = 26;
            btnCSUpdate.Text = "Course Sessions";
            btnCSUpdate.UseVisualStyleBackColor = false;
            btnCSUpdate.Click += btnCSUpdate_Click;
            // 
            // btnCSAUpdate
            // 
            btnCSAUpdate.BackColor = Color.FromArgb(47, 82, 189);
            btnCSAUpdate.Font = new Font("Poppins", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCSAUpdate.ForeColor = Color.White;
            btnCSAUpdate.Location = new Point(241, 214);
            btnCSAUpdate.Name = "btnCSAUpdate";
            btnCSAUpdate.Size = new Size(150, 47);
            btnCSAUpdate.TabIndex = 26;
            btnCSAUpdate.Text = "Course Attends";
            btnCSAUpdate.UseVisualStyleBackColor = false;
            btnCSAUpdate.Click += btnCSAUpdate_Click;
            // 
            // frmInsertMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 35, 47);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCrsUpdate);
            Controls.Add(btnDeptUpdate);
            Controls.Add(btnInstUpdate);
            Controls.Add(btnCSAUpdate);
            Controls.Add(btnCSUpdate);
            Controls.Add(btnStdUpdate);
            Controls.Add(btnBack);
            Controls.Add(picIntro);
            Controls.Add(lblChoose);
            Controls.Add(lblWelcome);
            Name = "frmInsertMain";
            Text = "Update";
            ((System.ComponentModel.ISupportInitialize)picIntro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picIntro;
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