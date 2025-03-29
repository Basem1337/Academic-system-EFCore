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
            btnSelectAll = new Button();
            btnBack = new Button();
            comboAll = new ComboBox();
            dgvStd = new DataGridView();
            label1 = new Label();
            comboRecord = new ComboBox();
            btnSelect = new Button();
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
            lblChoose.Size = new Size(163, 23);
            lblChoose.TabIndex = 6;
            lblChoose.Text = "Please, Choose a table.";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Poppins SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(30, 32);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(109, 50);
            lblWelcome.TabIndex = 7;
            lblWelcome.Text = "Select";
            // 
            // btnSelectAll
            // 
            btnSelectAll.BackColor = Color.FromArgb(47, 82, 189);
            btnSelectAll.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectAll.ForeColor = Color.White;
            btnSelectAll.Location = new Point(37, 162);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new Size(150, 47);
            btnSelectAll.TabIndex = 5;
            btnSelectAll.Text = "Select All";
            btnSelectAll.UseVisualStyleBackColor = false;
            btnSelectAll.Click += btnSelectAll_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(46, 64, 116);
            btnBack.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(590, 162);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 47);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // comboAll
            // 
            comboAll.FormattingEnabled = true;
            comboAll.Location = new Point(37, 117);
            comboAll.Name = "comboAll";
            comboAll.Size = new Size(331, 28);
            comboAll.TabIndex = 8;
            comboAll.SelectedIndexChanged += comboStd_SelectedIndexChanged;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(409, 82);
            label1.Name = "label1";
            label1.Size = new Size(172, 23);
            label1.TabIndex = 6;
            label1.Text = "Please, Choose a record.";
            // 
            // comboRecord
            // 
            comboRecord.FormattingEnabled = true;
            comboRecord.Location = new Point(409, 117);
            comboRecord.Name = "comboRecord";
            comboRecord.Size = new Size(331, 28);
            comboRecord.TabIndex = 8;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.FromArgb(47, 82, 189);
            btnSelect.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(218, 162);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(150, 47);
            btnSelect.TabIndex = 5;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // frmSelect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 35, 47);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvStd);
            Controls.Add(comboRecord);
            Controls.Add(label1);
            Controls.Add(comboAll);
            Controls.Add(lblChoose);
            Controls.Add(lblWelcome);
            Controls.Add(btnBack);
            Controls.Add(btnSelect);
            Controls.Add(btnSelectAll);
            Name = "frmSelect";
            Text = "Select";
            ((System.ComponentModel.ISupportInitialize)dgvStd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChoose;
        private Label lblWelcome;
        private Button btnSelectAll;
        private Button btnBack;
        private ComboBox comboAll;
        private DataGridView dgvStd;
        private Label label1;
        private ComboBox comboRecord;
        private Button btnSelect;
    }
}