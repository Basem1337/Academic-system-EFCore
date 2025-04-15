using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.DataRepository;
using AcademicDatabaseSystem.Forms;
using AcademicDatabaseSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp
{
    public partial class frmInstInsert : Form
    {
        DatabaseContext db = new();
        public frmInstInsert()
        {
            InitializeComponent();
            FillDeptComboBox();
            txtDeptID.Hide();
            lblRowsMsg.Hide();
            lblFname.Hide();
            lblLname.Hide();
            lblPhone.Hide();
            lblSalary.Hide();
            lblDeptID.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmInsertMain mainMenu = new frmInsertMain();
            mainMenu.Show();
            this.Close();
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
            lblFname.Hide();
            lblLname.Hide();
            lblPhone.Hide();
            lblSalary.Hide();
            lblDeptID.Hide();

            if (!Validations.CheckName(txtFName.Text) && !string.IsNullOrWhiteSpace(txtFName.Text))
            {
                lblFname.Show();
                return;
            }


            if (!Validations.CheckName(txtLName.Text) && !string.IsNullOrWhiteSpace(txtLName.Text))
            {
                lblLname.Show();
                return;
            }


            if (!Validations.CheckPhone(txtPhone.Text) && !string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                lblPhone.Show();
                return;
            }


            if (!Validations.CheckNumber(txtSalary.Text) && !string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                lblSalary.Show();
                return;
            }

            //if (!Validations.CheckNumber(txtDeptID.Text) && !string.IsNullOrWhiteSpace(txtDeptID.Text))
            //{
            //    lblDeptID.Show();
            //    return;
            //}

            if (string.IsNullOrWhiteSpace(txtFName.Text) || string.IsNullOrWhiteSpace(txtLName.Text)
                //|| string.IsNullOrWhiteSpace(txtDeptID.Text)
                )
            {
                lblRowsMsg.ForeColor = Color.Red;
                lblRowsMsg.Text = "There are fields that cannot be empty..";
                lblRowsMsg.Show();
                return;
            }

            Instructor newRecord = new()
            {
                InsFName = txtFName.Text,
                InsLName = txtLName.Text,
                Salary = Convert.ToDecimal(txtSalary.Text),
                Phone = txtPhone.Text,
                Dept_ID = Convert.ToInt32(comboDept.SelectedValue)
            };

            db.Instructors.Add(newRecord);
            db.SaveChanges();
            lblRowsMsg.ForeColor = Color.FromArgb(68, 187, 164);
            lblRowsMsg.Text = "1 Row Added Successfully"; 
            lblRowsMsg.Show();
        }

    }
}
