using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.Forms;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp
{
    public partial class frmDeptUpdate : Form
    {
        DatabaseContext db = new();
        public frmDeptUpdate()
        {
            InitializeComponent();
            FillComboBox();
            lblRowsMsg.Hide();
        }

        private void FillComboBox()
        {
            db.Departments.Load();
            dgvAll.DataSource = db.Departments.Local.ToBindingList();
            comboAll.DataSource = db.Departments.Local
                .Select(ent => new { DeptName = ent.Dept_Name, ent.Dept_ID })
                .ToList();
            comboAll.DisplayMember = "DeptName";
            comboAll.ValueMember = "Dept_ID";
        }

        private void comboStd_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Text = db.Departments.Local
            .Where(ent => ent.Dept_ID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.Dept_ID)
            .FirstOrDefault()
            .ToString();

            txtDeptName.Text = db.Departments.Local
            .Where(ent => ent.Dept_ID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.Dept_Name)
            .FirstOrDefault()
            .ToString();

            txtLocation.Text = db.Departments.Local
            .Where(ent => ent.Dept_ID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.Dept_Location)
            .FirstOrDefault()
            .ToString();

            txtManager.Text = db.Departments.Local
            .Where(ent => ent.Dept_ID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.ManagerID)
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
            var toUpdate = db.Departments.Local.FirstOrDefault(ent => ent.Dept_ID == Convert.ToInt32(comboAll.SelectedValue));

            bool op1 = toUpdate.Dept_Name == txtDeptName.Text;
            bool op2 = toUpdate.Dept_Location == txtLocation.Text;
            bool op3 = toUpdate.ManagerID.ToString() == txtManager.Text;

            lblRowsMsg.Hide();

            if (string.IsNullOrWhiteSpace(txtDeptName.Text) || string.IsNullOrWhiteSpace(txtManager.Text))
            {
                lblRowsMsg.ForeColor = Color.Red;
                lblRowsMsg.Text = "There are fields that cannot be empty..";
                lblRowsMsg.Show();
                return;
            }

            if (!op1 || !op2 || !op3)
            {
                toUpdate.Dept_Name = txtDeptName.Text;
                toUpdate.Dept_Location = txtLocation.Text;
                toUpdate.ManagerID = Convert.ToInt32(txtManager.Text);

                dgvAll.EndEdit();
                db.SaveChanges();
                FillComboBox();
                lblRowsMsg.ForeColor = Color.FromArgb(68, 187, 164);
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
