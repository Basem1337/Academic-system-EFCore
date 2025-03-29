using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.Forms;
using AcademicDatabaseSystem.Models;

namespace WinFormsApp
{
    public partial class frmCrsInsert : Form
    {
        DatabaseContext db = new();
        public frmCrsInsert()
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
            Course newRecord = new()
            {
                CrsName = txtCrsName.Text,
                CrsDuration = Convert.ToInt32(txtDur.Text),
                DeptID = Convert.ToInt32(txtDeptID.Text),
                InsID = Convert.ToInt32(txtInsID.Text),
            };

            db.Courses.Add(newRecord);
            db.SaveChanges();
            lblRowsMsg.Show();
        }

    }
}
