using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.DataRepository;
using AcademicDatabaseSystem.Forms;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp
{
    public partial class frmCrsUpdate : Form
    {
        DatabaseContext db = new();
        public frmCrsUpdate()
        {
            InitializeComponent();
            txtDeptID.Hide();
            txtInstID.Hide();
            FillDeptComboBox();
            FillInstComboBox();
            FillComboBox();
            lblRowsMsg.Hide();
            lblCrsName.Hide();
            lblDur.Hide();
            lblDeptID.Hide();
            lblInsID.Hide();
        }

        private void FillComboBox()
        {
            db.Courses.Load();
            dgvAll.DataSource = db.Courses.Local.ToBindingList();
            comboAll.DataSource = db.Courses.Local
                .Select(ent => new { ent.CrsName, ent.CrsID })
                .ToList();
            comboAll.DisplayMember = "CrsName";
            comboAll.ValueMember = "CrsID";
        }

        private void FillDeptComboBox()
        {
            db.Courses.Include(i => i.Department).Load();

            comboDept.DataSource = db.Courses.Local
                .Select(i => i.Department)
                .Distinct()
                .Select(d => new { DeptName = d.Dept_Name, d.Dept_ID })
                .ToList();

            comboDept.DisplayMember = "DeptName";
            comboDept.ValueMember = "Dept_ID";
        }
        private void FillInstComboBox()
        {
            db.Courses.Include(i => i.Instructor).Load();

            comboInst.DataSource = db.Courses.Local
                .Select(i => i.Instructor)
                .Distinct()
                .Select(i => new { InstName = i.InsFName + " " + i.InsLName, i.InsID })
                .ToList();

            comboInst.DisplayMember = "InstName";
            comboInst.ValueMember = "InsID";
        }

        private void comboStd_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Text = db.Courses.Local
            .Where(ent => ent.CrsID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.CrsID)
            .FirstOrDefault()
            .ToString();

            txtCrsName.Text = db.Courses.Local
            .Where(ent => ent.CrsID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.CrsName)
            .FirstOrDefault()
            .ToString();

            txtDur.Text = db.Courses.Local
            .Where(ent => ent.CrsID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.CrsDuration)
            .FirstOrDefault()
            .ToString();

            //txtDeptID.Text = db.Courses.Local
            //.Where(ent => ent.CrsID == Convert.ToInt32(comboAll.SelectedValue))
            //.Select(ent => ent.DeptID)
            //.FirstOrDefault()
            //.ToString();

            //txtInstID.Text = db.Courses.Local
            //.Where(ent => ent.CrsID == Convert.ToInt32(comboAll.SelectedValue))
            //.Select(ent => ent.InsID)
            //.FirstOrDefault()
            //.ToString();

            comboDept.SelectedValue = db.Courses.Local
            .Where(ent => ent.CrsID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.DeptID)
            .FirstOrDefault();

            comboInst.SelectedValue = db.Courses.Local
            .Where(ent => ent.CrsID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.InsID)
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
            var toUpdate = db.Courses.Local.FirstOrDefault(ent => ent.CrsID == Convert.ToInt32(comboAll.SelectedValue));

            bool op1 = toUpdate.CrsName == txtCrsName.Text;
            bool op2 = toUpdate.CrsDuration.ToString() == txtDur.Text;
            //bool op3 = toUpdate.DeptID.ToString() == txtDeptID.Text;
            bool op3 = toUpdate.DeptID.ToString() == comboDept.SelectedValue?.ToString();
            //bool op4 = toUpdate.InsID.ToString() == txtInstID.Text;
            bool op4 = toUpdate.InsID.ToString() == comboInst.SelectedValue?.ToString();

            lblRowsMsg.Hide();
            lblCrsName.Hide();
            lblDur.Hide();
            lblDeptID.Hide();
            lblInsID.Hide();

            if (!Validations.CheckCrsName(txtCrsName.Text))
            {
                lblCrsName.Show();
                return;
            }


            if (!Validations.CheckNumber(txtDur.Text))
            {
                lblDur.Show();
                return;
            }
            
            //if (!Validations.CheckNumber(txtInstID.Text))
            //{
            //    lblInsID.Show();
            //    return;
            //}
            
            //if (!Validations.CheckNumber(txtDeptID.Text))
            //{
            //    lblDeptID.Show();
            //    return;
            //}


            if (string.IsNullOrWhiteSpace(txtCrsName.Text) 
                //|| string.IsNullOrWhiteSpace(txtDeptID.Text) || string.IsNullOrWhiteSpace(txtInstID.Text)
                )
            {
                lblRowsMsg.ForeColor = Color.Red;
                lblRowsMsg.Text = "There are fields that cannot be empty..";
                lblRowsMsg.Show();
                return;
            }

            if (!op1 || !op2 || !op3 || !op4)
            {
                toUpdate.CrsName = txtCrsName.Text;
                toUpdate.CrsDuration = Convert.ToInt32(txtDur.Text);
                //toUpdate.DeptID = Convert.ToInt32(txtDeptID.Text);
                //toUpdate.InsID = Convert.ToInt32(txtInstID.Text);
                toUpdate.DeptID = Convert.ToInt32(comboDept.SelectedValue);
                toUpdate.InsID = Convert.ToInt32(comboInst.SelectedValue);
                
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
