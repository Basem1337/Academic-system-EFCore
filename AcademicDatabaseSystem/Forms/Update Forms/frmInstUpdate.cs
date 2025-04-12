using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.DataRepository;
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
            comboDept.Hide();
            FillDeptComboBox();
            lblRowsMsg.Hide();
            lblFname.Hide();
            lblLname.Hide();
            lblPhone.Hide();
            lblSalary.Hide();
            lblDeptID.Hide();
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

        private void FillDeptComboBox()
        {
            db.Instructors.Include(i => i.Department).Load();

            comboDept.DataSource = db.Instructors.Local
                .Select(i => i.Department)
                .Distinct()
                .Select(d => new { DeptName = d.Dept_Name, d.Dept_ID })
                .ToList();

            comboDept.DisplayMember = "DeptName";
            comboDept.ValueMember = "Dept_ID";
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

            comboDept.SelectedValue = db.Instructors.Local
            .Where(ent => ent.InsID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.Dept_ID)
            .FirstOrDefault();
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
            bool op6 = toUpdate.Dept_ID.ToString() == comboDept.ValueMember;

            lblRowsMsg.Hide();
            lblFname.Hide();
            lblLname.Hide();
            lblPhone.Hide();
            lblSalary.Hide();
            //lblDeptID.Hide();

            if (!Validations.CheckName(txtFName.Text))
            {
                lblFname.Show();
                return;
            }


            if (!Validations.CheckName(txtLName.Text))
            {
                lblLname.Show();
                return;
            }


            if (!Validations.CheckPhone(txtPhone.Text))
            {
                lblPhone.Show();
                return;
            }


            if (!Validations.CheckSalary(txtSalary.Text))
            {
                lblSalary.Show();
                return;
            }

            if (!Validations.CheckNumber(txtDeptID.Text))
            {
                lblDeptID.Show();
                return;
            }


            if (string.IsNullOrWhiteSpace(txtFName.Text) || string.IsNullOrWhiteSpace(txtLName.Text)
                || string.IsNullOrWhiteSpace(txtDeptID.Text)
                )
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
                //toUpdate.Dept_ID = Convert.ToInt32(comboDept.ValueMember);

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
