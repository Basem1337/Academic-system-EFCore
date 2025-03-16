namespace WinFormsApp
{
    partial class frmSelect
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
            btnSelect = new Button();
            btnBack = new Button();
            comboStd = new ComboBox();
            dgvStd = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStd).BeginInit();
            SuspendLayout();
            // 
            // lblChoose
            // 
            lblChoose.AutoSize = true;
            lblChoose.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChoose.ForeColor = Color.DarkGray;
            lblChoose.Location = new Point(37, 82);
            lblChoose.Name = "lblChoose";
            lblChoose.Size = new Size(179, 23);
            lblChoose.TabIndex = 6;
            lblChoose.Text = "Please, Choose a student.";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Poppins SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(30, 32);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(281, 50);
            lblWelcome.TabIndex = 7;
            lblWelcome.Text = "\"Select\" Operation";
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.FromArgb(47, 82, 189);
            btnSelect.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(37, 162);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(150, 47);
            btnSelect.TabIndex = 5;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(46, 64, 116);
            btnBack.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(218, 162);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 47);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // comboStd
            // 
            comboStd.FormattingEnabled = true;
            comboStd.Location = new Point(37, 117);
            comboStd.Name = "comboStd";
            comboStd.Size = new Size(331, 28);
            comboStd.TabIndex = 8;
            comboStd.SelectedIndexChanged += comboStd_SelectedIndexChanged;
            // 
            // dgvStd
            // 
            dgvStd.BackgroundColor = SystemColors.ControlLight;
            dgvStd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStd.Dock = DockStyle.Bottom;
            dgvStd.Location = new Point(0, 238);
            dgvStd.Name = "dgvStd";
            dgvStd.RowHeadersWidth = 51;
            dgvStd.Size = new Size(800, 212);
            dgvStd.TabIndex = 9;
            // 
            // frmSelect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 35, 47);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvStd);
            Controls.Add(comboStd);
            Controls.Add(lblChoose);
            Controls.Add(lblWelcome);
            Controls.Add(btnBack);
            Controls.Add(btnSelect);
            Name = "frmSelect";
            Text = "Select Student";
            ((System.ComponentModel.ISupportInitialize)dgvStd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChoose;
        private Label lblWelcome;
        private Button btnSelect;
        private Button btnBack;
        private ComboBox comboStd;
        private DataGridView dgvStd;
    }
}