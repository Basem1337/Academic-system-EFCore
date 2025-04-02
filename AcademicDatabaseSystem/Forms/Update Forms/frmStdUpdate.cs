using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace WinFormsApp
{
    public partial class frmStdUpdate : Form
    {
        DatabaseContext db = new();
        public frmStdUpdate()
        {
            InitializeComponent();
            FillComboBox();
            lblRowsMsg.Hide();
        }

        private void FillComboBox()
        {
            db.Students.Load();
            dgvAll.DataSource = db.Students.Local.ToBindingList();
            comboAll.DataSource = db.Students.Local
                .Select(ent => new { FullName = ent.St_FName + " " + ent.St_LName, ent.St_ID })
                .ToList();
            comboAll.DisplayMember = "FullName";
            comboAll.ValueMember = "St_ID";
        }

        private void comboStd_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Text = db.Students.Local
            .Where(ent => ent.St_ID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.St_ID)
            .FirstOrDefault()
            .ToString();

            txtFName.Text = db.Students.Local
            .Where(ent => ent.St_ID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.St_FName)
            .FirstOrDefault()
            .ToString();
            
            txtLName.Text = db.Students.Local
            .Where(ent => ent.St_ID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.St_LName)
            .FirstOrDefault()
            .ToString();
            
            txtPhone.Text = db.Students.Local
            .Where(ent => ent.St_ID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.St_Phone)
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
            var toUpdate = db.Students.Local.FirstOrDefault(ent => ent.St_ID == Convert.ToInt32(comboAll.SelectedValue));

            bool op1 = toUpdate.St_FName == txtFName.Text;
            bool op2 = toUpdate.St_LName == txtLName.Text;
            bool op3 = toUpdate.St_Phone == txtPhone.Text;


            lblRowsMsg.Hide();

            if (string.IsNullOrWhiteSpace(txtFName.Text) || string.IsNullOrWhiteSpace(txtLName.Text))
            {
                lblRowsMsg.ForeColor = Color.Red;
                lblRowsMsg.Text = "There are fields that cannot be empty..";
                lblRowsMsg.Show();
                return;
            }

            if (!op1 || !op2 || !op3)
            {
                toUpdate.St_FName = txtFName.Text;
                toUpdate.St_LName = txtLName.Text;
                toUpdate.St_Phone = txtPhone.Text;

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

    }
}
