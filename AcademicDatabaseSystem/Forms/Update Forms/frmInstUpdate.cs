using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.Forms;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp
{
    public partial class frmInstUpdate : Form
    {
        DatabaseContext db = new();
        public frmInstUpdate()
        {
            InitializeComponent();
            FillComboBox();
            lblRowsMsg.Hide();
        }

        private void FillComboBox()
        {
            db.Instructors.Load();
            dgvAll.DataSource = db.Instructors.Local.ToBindingList();
            comboAll.DataSource = db.Instructors.Local
                .Select(ent => new { FullName = ent.InsFName + " " + ent.InsLName, ent.InsID })
                .ToList();
            comboAll.DisplayMember = "FullName";
            comboAll.ValueMember = "InsID";
        }

        private void comboStd_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Text = db.Instructors.Local
            .Where(ent => ent.InsID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.InsID)
            .FirstOrDefault()
            .ToString();

            txtFName.Text = db.Instructors.Local
            .Where(ent => ent.InsID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.InsFName)
            .FirstOrDefault()
            .ToString();

            txtLName.Text = db.Instructors.Local
            .Where(ent => ent.InsID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.InsLName)
            .FirstOrDefault()
            .ToString();

            txtPhone.Text = db.Instructors.Local
            .Where(ent => ent.InsID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.Phone)
            .FirstOrDefault()
            .ToString();
            
            txtSalary.Text = db.Instructors.Local
            .Where(ent => ent.InsID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.Salary)
            .FirstOrDefault()
            .ToString();
            
            txtDeptID.Text = db.Instructors.Local
            .Where(ent => ent.InsID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.Dept_ID)
            .FirstOrDefault()
            .ToString();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            frmUpdateMain mainMenu = new frmUpdateMain();
            mainMenu.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var toUpdate = db.Instructors.Local.FirstOrDefault(ent => ent.InsID == Convert.ToInt32(comboAll.SelectedValue));

            bool op1 = toUpdate.InsFName == txtFName.Text;
            bool op2 = toUpdate.InsLName == txtLName.Text;
            bool op3 = toUpdate.Phone == txtPhone.Text;
            bool op4 = toUpdate.Salary.ToString() == txtSalary.Text;
            bool op5 = toUpdate.Dept_ID.ToString() == txtDeptID.Text;

            lblRowsMsg.Hide();

            if (string.IsNullOrWhiteSpace(txtFName.Text) || string.IsNullOrWhiteSpace(txtLName.Text) || string.IsNullOrWhiteSpace(txtDeptID.Text))
            {
                lblRowsMsg.ForeColor = Color.Red;
                lblRowsMsg.Text = "There are fields that cannot be empty..";
                lblRowsMsg.Show();
                return;
            }

            if (!op1 || !op2 || !op3 || !op4 || !op5)
            {
                toUpdate.InsFName = txtFName.Text;
                toUpdate.InsLName = txtLName.Text;
                toUpdate.Phone = txtPhone.Text;
                toUpdate.Salary = Convert.ToDecimal(txtSalary.Text);
                toUpdate.Dept_ID = Convert.ToInt32(txtDeptID.Text);

                dgvAll.EndEdit();
                db.SaveChanges();
                FillComboBox();
                lblRowsMsg.ForeColor = Color.DodgerBlue;
                lblRowsMsg.Text = "1 Row Affected";
                lblRowsMsg.Show();
            }
            else
            {
                lblRowsMsg.ForeColor = Color.Red;
                lblRowsMsg.Text = "Update any data first..";
                lblRowsMsg.Show();
            }

        }

        private void frmInstUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
