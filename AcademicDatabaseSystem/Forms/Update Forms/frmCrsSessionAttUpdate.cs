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
            txtCrsSessionID.Hide();
            txtStdID.Hide();
            FillStdComboBox();
            FillCrsSessionComboBox();
            txtStdID.Hide();
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

        private void FillStdComboBox()
        {
            db.CrsSessionAtts.Include(i => i.Student).Load();

            comboStd.DataSource = db.CrsSessionAtts.Local
                .Select(i => i.Student)
                .Distinct()
                .Select(d => new { StdName = d.St_FName + " " + d.St_LName, d.St_ID })
                .ToList();

            comboStd.DisplayMember = "StdName";
            comboStd.ValueMember = "St_ID";
        }
        private void FillCrsSessionComboBox()
        {
            db.CrsSessionAtts.Include(i => i.CrsSID).Load();

            comboCrsSession.DataSource = db.CrsSessionAtts.Local
                .Select(i => i.CrsSID)
                .Distinct()
                .Select(d => new { d.Title, d.CrsSID })
                .ToList();

            comboCrsSession.DisplayMember = "Title";
            comboCrsSession.ValueMember = "CrsSID";
        }

        private void comboStd_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Text = db.CrsSessionAtts.Local
            .Where(ent => ent.CrsSAID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.CrsSAID)
            .FirstOrDefault()
            .ToString();

            //txtStdID.Text = db.CrsSessionAtts.Local
            //.Where(ent => ent.CrsSAID == Convert.ToInt32(comboAll.SelectedValue))
            //.Select(ent => ent.StdID)
            //.FirstOrDefault()
            //.ToString();

            //txtCrsSessionID.Text = db.CrsSessionAtts.Local
            //.Where(ent => ent.CrsSAID == Convert.ToInt32(comboAll.SelectedValue))
            //.Select(ent => ent.CrsSessionID)
            //.FirstOrDefault()
            //.ToString();

            comboStd.SelectedValue = db.CrsSessionAtts.Local
            .Where(ent => ent.CrsSAID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.StdID)
            .FirstOrDefault();

            comboCrsSession.SelectedValue = db.CrsSessionAtts.Local
            .Where(ent => ent.CrsSAID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.CrsSessionID)
            .FirstOrDefault();

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

            //bool op1 = toUpdate.StdID.ToString() == txtStdID.Text;
            //bool op2 = toUpdate.CrsSessionID.ToString() == txtCrsSessionID.Text;
            bool op1 = toUpdate.StdID.ToString() == comboStd.SelectedValue?.ToString();
            bool op2 = toUpdate.CrsSessionID.ToString() == comboCrsSession.SelectedValue?.ToString();
            bool op3 = toUpdate.Grade.ToString() == txtGrade.Text;
            bool op4 = toUpdate.Notes.ToString() == txtNotes.Text;

            lblRowsMsg.Hide();

            //if (string.IsNullOrWhiteSpace(txtStdID.Text) || string.IsNullOrWhiteSpace(txtCrsSessionID.Text))
            //{
            //    lblRowsMsg.ForeColor = Color.Red;
            //    lblRowsMsg.Text = "There are fields that cannot be empty..";
            //    lblRowsMsg.Show();
            //    return;
            //}

            if (!op1 || !op2 || !op3 || !op4)
            {
                //toUpdate.StdID = Convert.ToInt32(txtStdID.Text);
                //toUpdate.CrsSessionID = Convert.ToInt32(txtCrsSessionID.Text);
                toUpdate.StdID = Convert.ToInt32(comboStd.SelectedValue);
                toUpdate.CrsSessionID = Convert.ToInt32(comboCrsSession.SelectedValue);
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
