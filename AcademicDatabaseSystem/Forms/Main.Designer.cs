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
            ((System.ComponentModel.ISupportInitialize)picIntro).BeginInit();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.FromArgb(47, 82, 189);
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
            btnInsert.BackColor = Color.FromArgb(47, 82, 189);
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
            btnUpdate.BackColor = Color.FromArgb(47, 82, 189);
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
            btnDelete.BackColor = Color.FromArgb(47, 82, 189);
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
            lblWelcome.Font = new Font("Poppins SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(32, 36);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(157, 50);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome";
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
            // frmParent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 35, 47);
            ClientSize = new Size(800, 450);
            Controls.Add(picIntro);
            Controls.Add(lblChoose);
            Controls.Add(lblWelcome);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnSelect);
            Name = "frmParent";
            Text = "Main Menu";
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
    }
}
