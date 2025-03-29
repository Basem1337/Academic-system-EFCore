using AcademicDatabaseSystem.Context;
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
            FillComboBox();
            lblRowsMsg.Hide();
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

            txtDeptID.Text = db.Courses.Local
            .Where(ent => ent.CrsID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.DeptID)
            .FirstOrDefault()
            .ToString();
            
            txtInstID.Text = db.Courses.Local
            .Where(ent => ent.CrsID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.InsID)
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
            var toUpdate = db.Courses.Local.FirstOrDefault(ent => ent.CrsID == Convert.ToInt32(comboAll.SelectedValue));

            bool op1 = toUpdate.CrsName == txtCrsName.Text;
            bool op2 = toUpdate.CrsDuration.ToString() == txtDur.Text;
            bool op3 = toUpdate.DeptID.ToString() == txtDeptID.Text;
            bool op4 = toUpdate.InsID.ToString() == txtInstID.Text;

            lblRowsMsg.Hide();

            if (!op1 || !op2 || !op3 || !op4)
            {
                toUpdate.CrsName = txtCrsName.Text;
                toUpdate.CrsDuration = Convert.ToInt32(txtDur.Text);
                toUpdate.DeptID = Convert.ToInt32(txtDeptID.Text);
                toUpdate.InsID = Convert.ToInt32(txtInstID.Text);
                
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
