using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.DataRepository;
using AcademicDatabaseSystem.Forms;
using AcademicDatabaseSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp
{
    public partial class frmCrsSessionInsert : Form
    {
        DatabaseContext db = new();
        public frmCrsSessionInsert()
        {
            InitializeComponent();
            txtCrsID.Hide();
            txtInsID.Hide();
            FillCrsComboBox();
            FillInstComboBox();
            lblRowsMsg.Hide();
            lblInsID.Hide();
            lblCrsID.Hide();
            lblDate.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmInsertMain mainMenu = new frmInsertMain();
            mainMenu.Show();
            this.Close();
        }

        private void FillCrsComboBox()
        {
            db.Crs_Sessions.Include(i => i.Course).Load();

            comboCrs.DataSource = db.Crs_Sessions.Local
                .Select(i => i.Course)
                .Distinct()
                .Select(d => new { CrsName = d.CrsName, d.CrsID })
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            lblRowsMsg.Hide();
            lblInsID.Hide();
            lblCrsID.Hide();
            lblDate.Hide();

            //if (!Validations.CheckName(txtInsID.Text) && !string.IsNullOrWhiteSpace(txtInsID.Text))
            //{
            //    lblInsID.Show();
            //    return;
            //}

            //if (!Validations.CheckName(txtCrsID.Text) && !string.IsNullOrWhiteSpace(txtCrsID.Text))
            //{
            //    lblCrsID.Show();
            //    return;
            //}

            if (!Validations.CheckNumber(txtDate.Text) && !string.IsNullOrWhiteSpace(txtDate.Text))
            {
                lblDate.Show();
                return;
            }

            if (
                //string.IsNullOrWhiteSpace(txtInsID.Text) || string.IsNullOrWhiteSpace(txtCrsID.Text) ||
                string.IsNullOrWhiteSpace(txtDate.Text))
            {
                lblRowsMsg.ForeColor = Color.Red;
                lblRowsMsg.Text = "There are fields that cannot be empty..";
                lblRowsMsg.Show();
                return;
            }

            CourseSession newRecord = new()
            {
                //CrsID = Convert.ToInt32(txtCrsID.Text),
                //InsID = Convert.ToInt32(txtInsID.Text),
                CrsID = Convert.ToInt32(comboCrs.SelectedValue),
                InsID = Convert.ToInt32(comboInst.SelectedValue),
                Title = txtTitle.Text,
                Date = Convert.ToDateTime(txtDate.Text),
            };

            db.Crs_Sessions.Add(newRecord);
            db.SaveChanges();
            lblRowsMsg.ForeColor = Color.FromArgb(68, 187, 164);
            lblRowsMsg.Text = "1 Row Added Successfully";
            lblRowsMsg.Show();
        }

    }
}
