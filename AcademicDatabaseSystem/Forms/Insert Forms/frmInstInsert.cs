using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.Forms;
using AcademicDatabaseSystem.Models;

namespace WinFormsApp
{
    public partial class frmInstInsert : Form
    {
        DatabaseContext db = new();
        public frmInstInsert()
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
            Instructor newRecord = new()
            {
                InsFName = txtFName.Text,
                InsLName = txtLName.Text,
                Salary = Convert.ToDecimal(txtSalary.Text),
                Phone = txtPhone.Text,
                Dept_ID = Convert.ToInt32(txtDeptID.Text)
            };

            db.Instructors.Add(newRecord);
            db.SaveChanges();
            lblRowsMsg.Show();
        }

    }
}
