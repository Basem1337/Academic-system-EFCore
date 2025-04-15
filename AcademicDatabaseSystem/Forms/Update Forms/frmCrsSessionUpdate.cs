using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.DataRepository;
using AcademicDatabaseSystem.Forms;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp
{
    public partial class frmCrsSessionUpdate : Form
    {
        DatabaseContext db = new();
        public frmCrsSessionUpdate()
        {
            InitializeComponent();
            txtCrsID.Hide();
            txtInstID.Hide();
            FillComboBox();
            FillCrsComboBox();
            FillInstComboBox();
            lblRowsMsg.Hide();
            lblCrsID.Hide();
            lblInsID.Hide();
            lblDate.Hide();
        }

        private void FillComboBox()
        {
            db.Crs_Sessions.Load();
            dgvAll.DataSource = db.Crs_Sessions.Local.ToBindingList();
            comboAll.DataSource = db.Crs_Sessions.Local
                .Select(ent => new { ent.Title, ent.CrsSID })
                .ToList();
            comboAll.DisplayMember = "Title";
            comboAll.ValueMember = "CrsSID";
        }

        private void FillCrsComboBox()
        {
            db.Crs_Sessions.Include(i => i.Course).Load();

            comboCrs.DataSource = db.Crs_Sessions.Local
                .Select(i => i.Course)
                .Distinct()
                .Select(d => new { d.CrsName, d.CrsID })
                .ToList();

            comboCrs.DisplayMember = "CrsName";
            comboCrs.ValueMember = "CrsID";
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
            txtId.Text = db.Crs_Sessions.Local
            .Where(ent => ent.CrsSID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.CrsSID)
            .FirstOrDefault()
            .ToString();

            //txtInstID.Text = db.Crs_Sessions.Local
            //.Where(ent => ent.CrsSID == Convert.ToInt32(comboAll.SelectedValue))
            //.Select(ent => ent.InsID)
            //.FirstOrDefault()
            //.ToString();

            //txtCrsID.Text = db.Crs_Sessions.Local
            //.Where(ent => ent.CrsSID == Convert.ToInt32(comboAll.SelectedValue))
            //.Select(ent => ent.CrsID)
            //.FirstOrDefault()
            //.ToString();

            comboInst.SelectedValue = db.Crs_Sessions.Local
            .Where(ent => ent.CrsSID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.InsID)
            .FirstOrDefault();

            comboCrs.SelectedValue = db.Crs_Sessions.Local
            .Where(ent => ent.CrsSID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.CrsID)
            .FirstOrDefault();

            txtTitle.Text = db.Crs_Sessions.Local
            .Where(ent => ent.CrsSID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.Title)
            .FirstOrDefault()
            .ToString();
            
            txtDate.Text = db.Crs_Sessions.Local
            .Where(ent => ent.CrsSID == Convert.ToInt32(comboAll.SelectedValue))
            .Select(ent => ent.Date)
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
            var toUpdate = db.Crs_Sessions.Local.FirstOrDefault(ent => ent.CrsID == Convert.ToInt32(comboAll.SelectedValue));

            //bool op1 = toUpdate.InsID.ToString() == txtInstID.Text;
            //bool op2 = toUpdate.CrsID.ToString() == txtCrsID.Text;
            bool op1 = toUpdate.InsID.ToString() == comboInst.SelectedValue?.ToString();
            bool op2 = toUpdate.CrsID.ToString() == comboCrs.SelectedValue?.ToString();
            bool op3 = toUpdate.Title.ToString() == txtTitle.Text;
            bool op4 = toUpdate.Date.ToString() == txtDate.Text;

            lblRowsMsg.Hide();

            lblInsID.Hide();
            lblCrsID.Hide();
            lblDate.Hide();

            //if (!Validations.CheckName(txtCrsID.Text))
            //{
            //    lblCrsID.Show();
            //    return;
            //}


            //if (!Validations.CheckNumber(txtInstID.Text))
            //{
            //    lblInsID.Show();
            //    return;
            //}

            if (!Validations.CheckDate(txtDate.Text))
            {
                lblDate.Show();
                return;
            }

            if (
                //string.IsNullOrWhiteSpace(txtInstID.Text) || string.IsNullOrWhiteSpace(txtCrsID.Text) ||
                string.IsNullOrWhiteSpace(txtDate.Text))
            {
                lblRowsMsg.ForeColor = Color.Red;
                lblRowsMsg.Text = "There are fields that cannot be empty..";
                lblRowsMsg.Show();
                return;
            }

            if (!op1 || !op2 || !op3 || !op4)
            {
                //toUpdate.InsID = Convert.ToInt32(txtInstID.Text);
                //toUpdate.CrsID = Convert.ToInt32(txtCrsID.Text);
                toUpdate.InsID = Convert.ToInt32(comboInst.SelectedValue);
                toUpdate.CrsID = Convert.ToInt32(comboCrs.SelectedValue);
                toUpdate.Title = txtTitle.Text;
                toUpdate.Date = Convert.ToDateTime(txtDate.Text);
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
