using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.Forms;
using AcademicDatabaseSystem.Models;

namespace WinFormsApp
{
    public partial class frmCrsSessionAttInsert : Form
    {
        DatabaseContext db = new();
        public frmCrsSessionAttInsert()
        {
            InitializeComponent();
            lblRowsMsg.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmInsertMain mainMenu = new frmInsertMain();
            mainMenu.Show();
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            CourseSessionAttendance newRecord = new()
            {
                Grade = Convert.ToInt32(txtGrade.Text),
                Notes = txtNotes.Text,
                CrsSessionID = Convert.ToInt32(txtCrsSID.Text),
                StdID = Convert.ToInt32(txtStdID.Text),
            };

            db.CrsSessionAtts.Add(newRecord);
            db.SaveChanges();
            lblRowsMsg.Show();
        }

    }
}
