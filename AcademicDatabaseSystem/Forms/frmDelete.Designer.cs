﻿namespace WinFormsApp
{
    partial class frmDelete
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
            dgvStd = new DataGridView();
            comboAll = new ComboBox();
            lblChoose = new Label();
            lblWelcome = new Label();
            btnBack = new Button();
            btnDelete = new Button();
            comboRecord = new ComboBox();
            lblRowsMsg = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStd).BeginInit();
            SuspendLayout();
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
            dgvStd.TabIndex = 15;
            // 
            // comboAll
            // 
            comboAll.FormattingEnabled = true;
            comboAll.Location = new Point(37, 115);
            comboAll.Name = "comboAll";
            comboAll.Size = new Size(331, 28);
            comboAll.TabIndex = 14;
            comboAll.SelectedIndexChanged += comboStd_SelectedIndexChanged;
            // 
            // lblChoose
            // 
            lblChoose.AutoSize = true;
            lblChoose.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChoose.ForeColor = Color.DarkGray;
            lblChoose.Location = new Point(37, 80);
            lblChoose.Name = "lblChoose";
            lblChoose.Size = new Size(319, 23);
            lblChoose.TabIndex = 12;
            lblChoose.Text = "Please, Choose a record from a table to delete.";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Poppins SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(30, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(112, 50);
            lblWelcome.TabIndex = 13;
            lblWelcome.Text = "Delete";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(85, 134, 140);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(593, 160);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 47);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(68, 187, 164);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(37, 160);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 47);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // comboRecord
            // 
            comboRecord.FormattingEnabled = true;
            comboRecord.Location = new Point(412, 115);
            comboRecord.Name = "comboRecord";
            comboRecord.Size = new Size(331, 28);
            comboRecord.TabIndex = 19;
            // 
            // lblRowsMsg
            // 
            lblRowsMsg.AutoSize = true;
            lblRowsMsg.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRowsMsg.ForeColor = Color.FromArgb(68, 187, 164);
            lblRowsMsg.Location = new Point(297, 184);
            lblRowsMsg.Name = "lblRowsMsg";
            lblRowsMsg.Size = new Size(182, 23);
            lblRowsMsg.TabIndex = 18;
            lblRowsMsg.Text = "1 Row Deleted Successfully";
            // 
            // frmDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 49, 49);
            ClientSize = new Size(800, 450);
            Controls.Add(comboRecord);
            Controls.Add(lblRowsMsg);
            Controls.Add(dgvStd);
            Controls.Add(comboAll);
            Controls.Add(lblChoose);
            Controls.Add(lblWelcome);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Name = "frmDelete";
            Text = "Delete";
            ((System.ComponentModel.ISupportInitialize)dgvStd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStd;
        private ComboBox comboAll;
        private Label lblChoose;
        private Label lblWelcome;
        private Button btnBack;
        private Button btnDelete;
        private ComboBox comboRecord;
        private Label lblRowsMsg;
    }
}