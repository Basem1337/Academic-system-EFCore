using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.DataRepository;
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
            lblDeptName.Hide();
            lblMng.Hide();
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

            lblDeptName.Hide();
            lblMng.Hide();

            if (!Validations.CheckName(txtDeptName.Text) && !string.IsNullOrWhiteSpace(txtDeptName.Text))
            {
                lblDeptName.Show();
                return;
            }


            if (!Validations.CheckNumber(txtManagerID.Text) && !string.IsNullOrWhiteSpace(txtManagerID.Text))
            {
                lblMng.Show();
                return;
            }

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
            lblRowsMsg.ForeColor = Color.FromArgb(68, 187, 164);
            lblRowsMsg.Text = "1 Row Added Successfully";
            lblRowsMsg.Show();
        }

    }
}
