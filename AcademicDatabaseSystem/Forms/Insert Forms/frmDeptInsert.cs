using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.Forms;
using AcademicDatabaseSystem.Models;

namespace WinFormsApp
{
    public partial class frmDeptInsert : Form
    {
        DatabaseContext db = new();
        public frmDeptInsert()
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
            lblRowsMsg.Hide();

            if (string.IsNullOrWhiteSpace(txtDeptName.Text) || string.IsNullOrWhiteSpace(txtManagerID.Text))
            {
                lblRowsMsg.ForeColor = Color.Red;
                lblRowsMsg.Text = "There are fields that cannot be empty..";
                lblRowsMsg.Show();
                return;
            }

            Department newRecord = new()
            {
                Dept_Name = txtDeptName.Text,
                Dept_Location = txtLocation.Text,
                ManagerID = Convert.ToInt32(txtManagerID.Text)
            };

            db.Departments.Add(newRecord);
            db.SaveChanges();
            lblRowsMsg.ForeColor = Color.DodgerBlue;
            lblRowsMsg.Text = "1 Row Added Successfully";
            lblRowsMsg.Show();
        }

    }
}
