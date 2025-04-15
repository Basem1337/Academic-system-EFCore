namespace WinFormsApp
{
    partial class frmParent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParent));
            btnSelect = new Button();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblWelcome = new Label();
            lblChoose = new Label();
            picIntro = new PictureBox();
            btnBack = new Button();
            linkLinkedIn = new LinkLabel();
            linkGitHub = new LinkLabel();
            linkBehance = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)picIntro).BeginInit();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.FromArgb(68, 187, 164);
            btnSelect.FlatStyle = FlatStyle.Popup;
            btnSelect.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(39, 138);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(150, 47);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(68, 187, 164);
            btnInsert.FlatStyle = FlatStyle.Popup;
            btnInsert.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(39, 213);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(150, 47);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(68, 187, 164);
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(39, 287);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 47);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(68, 187, 164);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(39, 364);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 47);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(32, 36);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(169, 50);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome!";
            // 
            // lblChoose
            // 
            lblChoose.AutoSize = true;
            lblChoose.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChoose.ForeColor = Color.DarkGray;
            lblChoose.Location = new Point(39, 86);
            lblChoose.Name = "lblChoose";
            lblChoose.Size = new Size(341, 23);
            lblChoose.TabIndex = 1;
            lblChoose.Text = "Please, Choose the operation you want to perform.";
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
            picIntro.TabIndex = 2;
            picIntro.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Maroon;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Poppins Medium", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(703, 14);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(85, 36);
            btnBack.TabIndex = 23;
            btnBack.Text = "Exit";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // linkLinkedIn
            // 
            linkLinkedIn.ActiveLinkColor = Color.FromArgb(85, 134, 140);
            linkLinkedIn.AutoSize = true;
            linkLinkedIn.BackColor = Color.FromArgb(68, 187, 164);
            linkLinkedIn.Font = new Font("Poppins Medium", 7.8F, FontStyle.Bold);
            linkLinkedIn.LinkColor = Color.FromArgb(21, 49, 49);
            linkLinkedIn.Location = new Point(677, 418);
            linkLinkedIn.Name = "linkLinkedIn";
            linkLinkedIn.Size = new Size(70, 23);
            linkLinkedIn.TabIndex = 24;
            linkLinkedIn.TabStop = true;
            linkLinkedIn.Text = "LinkedIn";
            linkLinkedIn.TextAlign = ContentAlignment.MiddleCenter;
            linkLinkedIn.VisitedLinkColor = Color.Purple;
            linkLinkedIn.LinkClicked += linkLinkedIn_LinkClicked;
            // 
            // linkGitHub
            // 
            linkGitHub.ActiveLinkColor = Color.FromArgb(85, 134, 140);
            linkGitHub.AutoSize = true;
            linkGitHub.BackColor = Color.FromArgb(68, 187, 164);
            linkGitHub.Font = new Font("Poppins Medium", 7.8F, FontStyle.Bold);
            linkGitHub.LinkColor = Color.FromArgb(21, 49, 49);
            linkGitHub.Location = new Point(611, 418);
            linkGitHub.Name = "linkGitHub";
            linkGitHub.Size = new Size(60, 23);
            linkGitHub.TabIndex = 24;
            linkGitHub.TabStop = true;
            linkGitHub.Text = "GitHub";
            linkGitHub.TextAlign = ContentAlignment.MiddleCenter;
            linkGitHub.VisitedLinkColor = Color.Purple;
            linkGitHub.LinkClicked += linkGitHub_LinkClicked;
            // 
            // linkBehance
            // 
            linkBehance.ActiveLinkColor = Color.FromArgb(85, 134, 140);
            linkBehance.AutoSize = true;
            linkBehance.BackColor = Color.FromArgb(68, 187, 164);
            linkBehance.Font = new Font("Poppins Medium", 7.8F, FontStyle.Bold);
            linkBehance.LinkColor = Color.FromArgb(21, 49, 49);
            linkBehance.Location = new Point(531, 418);
            linkBehance.Name = "linkBehance";
            linkBehance.Size = new Size(74, 23);
            linkBehance.TabIndex = 24;
            linkBehance.TabStop = true;
            linkBehance.Text = "Behance";
            linkBehance.TextAlign = ContentAlignment.MiddleCenter;
            linkBehance.VisitedLinkColor = Color.Purple;
            linkBehance.LinkClicked += linkBehance_LinkClicked;
            // 
            // frmParent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 49, 49);
            ClientSize = new Size(800, 450);
            Controls.Add(linkBehance);
            Controls.Add(linkGitHub);
            Controls.Add(linkLinkedIn);
            Controls.Add(btnBack);
            Controls.Add(picIntro);
            Controls.Add(lblChoose);
            Controls.Add(lblWelcome);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnSelect);
            Name = "frmParent";
            Text = "Main Menu";
            //Load += frmParent_Load;
            ((System.ComponentModel.ISupportInitialize)picIntro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelect;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblWelcome;
        private Label lblChoose;
        private PictureBox picIntro;
        private Button btnBack;
        private LinkLabel linkLinkedIn;
        private LinkLabel linkGitHub;
        private LinkLabel linkBehance;
    }
}
