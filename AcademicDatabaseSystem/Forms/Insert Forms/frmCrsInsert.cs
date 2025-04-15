using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.DataRepository;
using AcademicDatabaseSystem.Forms;
using AcademicDatabaseSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp
{
    public partial class frmCrsInsert : Form
    {
        DatabaseContext db = new();
        public frmCrsInsert()
        {
            InitializeComponent();
            txtDeptID.Hide();
            txtInsID.Hide();
            FillDeptComboBox();
            FillInstComboBox();
            lblRowsMsg.Hide();
            lblCrsName.Hide();
            lblDur.Hide();
            lblDeptID.Hide();
            lblInsID.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmInsertMain mainMenu = new frmInsertMain();
            mainMenu.Show();
            this.Close();
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            lblRowsMsg.Hide();
            lblCrsName.Hide();
            lblDur.Hide();
            lblDeptID.Hide();
            lblInsID.Hide();

            if (!Validations.CheckCrsName(txtCrsName.Text) && !string.IsNullOrWhiteSpace(txtCrsName.Text))
            {
                lblCrsName.Show();
                return;
            }


            if (!Validations.CheckNumber(txtDur.Text) && !string.IsNullOrWhiteSpace(txtDur.Text))
            {
                lblDur.Show();
                return;
            }

            //if (!Validations.CheckNumber(txtInsID.Text) && !string.IsNullOrWhiteSpace(txtInsID.Text))
            //{
            //    lblInsID.Show();
            //    return;
            //}

            //if (!Validations.CheckNumber(txtDeptID.Text) && !string.IsNullOrWhiteSpace(txtDeptID.Text))
            //{
            //    lblDeptID.Show();
            //    return;
            //}

            if (string.IsNullOrWhiteSpace(txtCrsName.Text)
                //|| string.IsNullOrWhiteSpace(txtDeptID.Text)|| string.IsNullOrWhiteSpace(txtInsID.Text)
                )
            {
                lblRowsMsg.ForeColor = Color.Red;
                lblRowsMsg.Text = "There are fields that cannot be empty..";
                lblRowsMsg.Show();
                return;
            }

            Course newRecord = new()
            {
                CrsName = txtCrsName.Text,
                CrsDuration = Convert.ToInt32(txtDur.Text),
                //DeptID = Convert.ToInt32(txtDeptID.Text),
                //InsID = Convert.ToInt32(txtInsID.Text),
                DeptID = Convert.ToInt32(comboDept.SelectedValue),
                InsID = Convert.ToInt32(comboInst.SelectedValue),
            };

            db.Courses.Add(newRecord);
            db.SaveChanges();
            lblRowsMsg.ForeColor = Color.FromArgb(68, 187, 164);
            lblRowsMsg.Text = "1 Row Added Successfully";
            lblRowsMsg.Show();
        }

    }
}
