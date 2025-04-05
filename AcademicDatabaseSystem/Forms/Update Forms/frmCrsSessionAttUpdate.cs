using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.Forms;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp
{
    public partial class frmCrsSessionAttUpdate : Form
    {
        DatabaseContext db = new();
        public frmCrsSessionAttUpdate()
        {
            InitializeComponent();
            FillComboBox();
            lblRowsMsg.Hide();
        }

        private void FillComboBox()
        {
            db.CrsSessionAtts.Load();
            dgvAll.DataSource = db.CrsSessionAtts.Local.ToBindingList();
            comboAll.DataSource = db.CrsSessionAtts.Local
                .Select(ent => new { ent.CrsSAID })
                .ToList();
            comboAll.DisplayMember = "CrsSAID";
            comboAll.ValueMember = "CrsSAID";
        }

        private void comboStd_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Text = db.CrsSessionAtts.Local
            .Where(ent => ent.CrsSAID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.CrsSAID)
            .FirstOrDefault()
            .ToString();

            txtStdID.Text = db.CrsSessionAtts.Local
            .Where(ent => ent.CrsSAID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.StdID)
            .FirstOrDefault()
            .ToString();

            txtCrsSessionID.Text = db.CrsSessionAtts.Local
            .Where(ent => ent.CrsSAID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.CrsSessionID)
            .FirstOrDefault()
            .ToString();

            txtGrade.Text = db.CrsSessionAtts.Local
            .Where(ent => ent.CrsSAID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.Grade)
            .FirstOrDefault()
            .ToString();
            
            txtNotes.Text = db.CrsSessionAtts.Local
            .Where(ent => ent.CrsSAID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.Notes)
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
            var toUpdate = db.CrsSessionAtts.Local.FirstOrDefault(ent => ent.CrsSAID == Convert.ToInt32(comboAll.SelectedValue));

            bool op1 = toUpdate.StdID.ToString() == txtStdID.Text;
            bool op2 = toUpdate.CrsSessionID.ToString() == txtCrsSessionID.Text;
            bool op3 = toUpdate.Grade.ToString() == txtGrade.Text;
            bool op4 = toUpdate.Notes.ToString() == txtNotes.Text;

            lblRowsMsg.Hide();

            if (string.IsNullOrWhiteSpace(txtStdID.Text) || string.IsNullOrWhiteSpace(txtCrsSessionID.Text))
            {
                lblRowsMsg.ForeColor = Color.Red;
                lblRowsMsg.Text = "There are fields that cannot be empty..";
                lblRowsMsg.Show();
                return;
            }

            if (!op1 || !op2 || !op3 || !op4)
            {
                toUpdate.StdID = Convert.ToInt32(txtStdID.Text);
                toUpdate.CrsSessionID = Convert.ToInt32(txtCrsSessionID.Text);
                toUpdate.Grade = Convert.ToInt32(txtGrade.Text);
                toUpdate.Notes = txtNotes.Text;

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
