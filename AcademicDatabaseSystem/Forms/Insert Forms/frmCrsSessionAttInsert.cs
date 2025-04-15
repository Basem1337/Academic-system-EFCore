using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.Forms;
using AcademicDatabaseSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp
{
    public partial class frmCrsSessionAttInsert : Form
    {
        DatabaseContext db = new();
        public frmCrsSessionAttInsert()
        {
            InitializeComponent();
            txtStdID.Hide();
            txtCrsSID.Hide();
            FillStdComboBox();
            FillCrsSessionComboBox();
            lblRowsMsg.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmInsertMain mainMenu = new frmInsertMain();
            mainMenu.Show();
            this.Close();
        }

        private void FillStdComboBox()
        {
            db.CrsSessionAtts.Include(i => i.Student).Load();

            comboStd.DataSource = db.CrsSessionAtts.Local
                .Select(i => i.Student)
                .Distinct()
                .Select(d => new { StdName = d.St_FName + " " + d.St_LName, d.St_ID })
                .ToList();

            comboStd.DisplayMember = "StdName";
            comboStd.ValueMember = "St_ID";
        }
        private void FillCrsSessionComboBox()
        {
            db.CrsSessionAtts.Include(i => i.CrsSID).Load();

            comboCrsSession.DataSource = db.CrsSessionAtts.Local
                .Select(i => i.CrsSID)
                .Distinct()
                .Select(d => new { d.Title, d.CrsSID })
                .ToList();

            comboCrsSession.DisplayMember = "Title";
            comboCrsSession.ValueMember = "CrsSID";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            lblRowsMsg.Hide();

            //if (string.IsNullOrWhiteSpace(txtStdID.Text) || string.IsNullOrWhiteSpace(txtCrsSID.Text))
            //{
            //    lblRowsMsg.ForeColor = Color.Red;
            //    lblRowsMsg.Text = "There are fields that cannot be empty..";
            //    lblRowsMsg.Show();
            //    return;
            //}

            CourseSessionAttendance newRecord = new()
            {
                Grade = Convert.ToInt32(txtGrade.Text),
                Notes = txtNotes.Text,
                //CrsSessionID = Convert.ToInt32(txtCrsSID.Text),
                //StdID = Convert.ToInt32(txtStdID.Text),
                CrsSessionID = Convert.ToInt32(comboCrsSession.SelectedValue),
                StdID = Convert.ToInt32(comboStd.SelectedValue),
            };

            db.CrsSessionAtts.Add(newRecord);
            db.SaveChanges();
            lblRowsMsg.ForeColor = Color.FromArgb(68, 187, 164);
            lblRowsMsg.Text = "1 Row Added Successfully";
            lblRowsMsg.Show();
        }

    }
}
