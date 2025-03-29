using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp
{
    public partial class frmSelect : Form
    {
        DatabaseContext db = new();
        public frmSelect()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void FillComboBox()
        {
            //comboStd.DisplayMember = "St_Fname";
            //comboStd.ValueMember = "St_Id";

            comboAll.DataSource = new List<string>() {
                "Students",
                "Instructors",
                "Courses",
                "Departments",
                "Student Courses",
                "Course Sessions",
                "Course Sessions Attendance"
            };

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmParent mainMenu = new frmParent();
            mainMenu.Show();
            this.Close();
        }

        private void comboStd_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboAll.SelectedValue)
            {
                case "Courses":
                    db.Courses.Load();
                    comboRecord.DataSource = db.Courses.Local.Select(c => new { c.CrsName , c.CrsID }).ToList();
                    comboRecord.DisplayMember = "CrsName";
                    comboRecord.ValueMember = "CrsID";
                    break;
                case "Students":
                    db.Students.Load();
                    comboRecord.DataSource = db.Students.Local
                        .Select(s => new { FullName = s.St_FName + " " + s.St_LName , s.St_ID })
                        .ToList();
                    comboRecord.DisplayMember = "FullName";
                    comboRecord.ValueMember = "St_ID";
                    break;
                case "Instructors":
                    db.Instructors.Load();
                    comboRecord.DataSource = db.Instructors.Local
                        .Select(i => new { FullName = i.InsFName + " " + i.InsLName , i.InsID })
                        .ToList();
                    comboRecord.DisplayMember = "FullName";
                    comboRecord.ValueMember = "InsID";
                    break;
                case "Departments":
                    db.Departments.Load();
                    comboRecord.DataSource = db.Departments.Local.Select(d => new { d.Dept_Name , d.Dept_ID}).ToList();
                    comboRecord.DisplayMember = "Dept_Name";
                    comboRecord.ValueMember = "Dept_ID";
                    break;
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            switch (comboAll.SelectedValue)
            {
                case "Courses":
                    db.Courses.Load();
                    dgvStd.DataSource = db.Courses.Local.ToBindingList();
                    break;
                case "Students":
                    db.Students.Load();
                    dgvStd.DataSource = db.Students.Local.ToBindingList();
                    break;
                case "Instructors":
                    db.Instructors.Load();
                    dgvStd.DataSource = db.Instructors.Local.ToBindingList();
                    break;
                case "Departments":
                    db.Departments.Load();
                    dgvStd.DataSource = db.Departments.Local.ToBindingList();
                    break;
                case "Student Courses":
                    db.Std_Courses.Load();
                    dgvStd.DataSource = db.Std_Courses.Local.ToBindingList();
                    break;
                case "Course Sessions":
                    db.Crs_Sessions.Load();
                    dgvStd.DataSource = db.Crs_Sessions.Local.ToBindingList();
                    break;
                case "Course Sessions Attendance":
                    db.CrsSessionAtts.Load();
                    dgvStd.DataSource = db.CrsSessionAtts.Local.ToBindingList();
                    break;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            switch (comboAll.SelectedValue)
            {
                case "Courses":
                    db.Courses.Load();
                    dgvStd.DataSource = db.Courses.Local.Where(c=>c.CrsName == comboRecord.Text).ToList();
                    break;
                case "Students":
                    db.Students.Load();
                    dgvStd.DataSource = db.Students.Local.Where(s => (s.St_FName + " " + s.St_LName) == comboRecord.Text).ToList();
                    break;
                case "Instructors":
                    db.Instructors.Load();
                    dgvStd.DataSource = db.Instructors.Local.Where(i => (i.InsFName + " " + i.InsFName) == comboRecord.Text).ToList();
                    break;
                case "Departments":
                    db.Departments.Load();
                    dgvStd.DataSource = db.Departments.Local.Where(d => d.Dept_Name == comboRecord.Text).ToList();
                    break;
            }
        }
    }
}
