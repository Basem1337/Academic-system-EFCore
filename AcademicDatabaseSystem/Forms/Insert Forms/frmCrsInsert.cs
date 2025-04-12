using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.DataRepository;
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
            lblCrsName.Hide();
            lblDur.Hide();
            lblDeptID.Hide();
            lblInsID.Hide();
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

            lblCrsName.Hide();
            lblDur.Hide();
            lblDeptID.Hide();
            lblInsID.Hide();

            if (!Validations.CheckName(txtCrsName.Text) && !string.IsNullOrWhiteSpace(txtCrsName.Text))
            {
                lblCrsName.Show();
                return;
            }


            if (!Validations.CheckNumber(txtDur.Text) && !string.IsNullOrWhiteSpace(txtDur.Text))
            {
                lblDur.Show();
                return;
            }

            if (!Validations.CheckNumber(txtInsID.Text) && !string.IsNullOrWhiteSpace(txtInsID.Text))
            {
                lblInsID.Show();
                return;
            }

            if (!Validations.CheckNumber(txtDeptID.Text) && !string.IsNullOrWhiteSpace(txtDeptID.Text))
            {
                lblDeptID.Show();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCrsName.Text) || string.IsNullOrWhiteSpace(txtDeptID.Text) || string.IsNullOrWhiteSpace(txtInsID.Text))
            {
                lblRowsMsg.ForeColor = Color.Red;
                lblRowsMsg.Text = "There are fields that cannot be empty..";
                lblRowsMsg.Show();
                return;
            }

            Course newRecord = new()
            {
                CrsName = txtCrsName.Text,
                CrsDuration = Convert.ToInt32(txtDur.Text),
                DeptID = Convert.ToInt32(txtDeptID.Text),
                InsID = Convert.ToInt32(txtInsID.Text),
            };

            db.Courses.Add(newRecord);
            db.SaveChanges();
            lblRowsMsg.ForeColor = Color.FromArgb(68, 187, 164);
            lblRowsMsg.Text = "1 Row Added Successfully";
            lblRowsMsg.Show();
        }

    }
}
