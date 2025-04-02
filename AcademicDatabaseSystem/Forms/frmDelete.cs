using AcademicDatabaseSystem.Context;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp
{
    public partial class frmDelete : Form
    {
        DatabaseContext db = new();
        public frmDelete()
        {
            InitializeComponent();
            FillComboBox();
            lblRowsMsg.Hide();
        }

        private void FillComboBox()
        {
            comboAll.DataSource = new List<string>() {
                "Students",
                "Instructors",
                "Courses",
                "Departments",
                "Course Sessions",
                "Course Sessions Attendance"
            };
        }

        private void comboStd_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboAll.SelectedValue)
            {
                case "Courses":
                    db.Courses.Load();
                    comboRecord.DataSource = db.Courses.Local.Select(c => c.CrsName).ToList();
                    dgvStd.DataSource = db.Courses.Local.ToBindingList();
                    break;
                case "Students":
                    db.Students.Load();
                    comboRecord.DataSource = db.Students.Local
                        .Select(s => new { FullName = s.St_FName + " " + s.St_LName })
                        .ToList();
                    comboRecord.DisplayMember = "FullName";
                    dgvStd.DataSource = db.Students.Local.ToBindingList();
                    break;
                case "Instructors":
                    db.Instructors.Load();
                    comboRecord.DataSource = db.Instructors.Local
                        .Select(i => new { FullName = i.InsFName + " " + i.InsLName })
                        .ToList();
                    comboRecord.DisplayMember = "FullName";
                    dgvStd.DataSource = db.Instructors.Local.ToBindingList();
                    break;
                case "Departments":
                    db.Departments.Load();
                    comboRecord.DataSource = db.Departments.Local.Select(d => d.Dept_Name).ToList();
                    dgvStd.DataSource = db.Departments.Local.ToBindingList();
                    break;
                case "Course Sessions":
                    db.Crs_Sessions.Load();
                    comboRecord.DataSource = db.Crs_Sessions.Local.Select(d => new { d.CrsSID , d.Title}).ToList();
                    comboRecord.DisplayMember = "Title";
                    comboRecord.ValueMember = "CrsSID";
                    dgvStd.DataSource = db.Crs_Sessions.Local.ToBindingList();
                    break;
                case "Course Sessions Attendance":
                    db.CrsSessionAtts.Load();
                    comboRecord.DataSource = db.CrsSessionAtts.Local.Select(d => new { d.CrsSAID , d.Notes}).ToList();
                    comboRecord.DisplayMember = "Notes";
                    comboRecord.ValueMember = "CrsSAID";
                    dgvStd.DataSource = db.CrsSessionAtts.Local.ToBindingList();
                    break;
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            frmParent mainMenu = new frmParent();
            mainMenu.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete {comboRecord.Text} from the Database?", "WARNING!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                switch (comboAll.SelectedValue)
                {
                    case "Courses":
                        db.Courses.Load();
                        var delCrs = db.Courses.Local.FirstOrDefault(c=>c.CrsName == comboRecord.Text);
                        db.Courses.Remove(delCrs);
                        db.SaveChanges();
                        break;
                    case "Students":
                        db.Students.Load();
                        var delStd = db.Students.Local.FirstOrDefault(c => (c.St_FName + " " + c.St_LName) == comboRecord.Text);
                        db.Students.Remove(delStd);
                        db.SaveChanges();
                        break;
                    case "Instructors":
                        db.Instructors.Load();
                        var delInst = db.Instructors.Local.FirstOrDefault(c => (c.InsFName + " " + c.InsLName) == comboRecord.Text);
                        db.Instructors.Remove(delInst);
                        db.SaveChanges();
                        break;
                    case "Departments":
                        db.Departments.Load();
                        var delDept = db.Departments.Local.FirstOrDefault(c => c.Dept_Name == comboRecord.Text);
                        db.Departments.Remove(delDept);
                        db.SaveChanges();
                        break;
                    case "Course Sessions":
                        db.Crs_Sessions.Load();
                        var delCrsS = db.Crs_Sessions.Local.FirstOrDefault(c => c.Title == comboRecord.Text);
                        db.Crs_Sessions.Remove(delCrsS);
                        db.SaveChanges();
                        break;
                    case "Course Sessions Attendance":
                        db.CrsSessionAtts.Load();
                        var delCrsSAtt = db.CrsSessionAtts.Local.FirstOrDefault(c => c.Notes == comboRecord.Text);
                        db.CrsSessionAtts.Remove(delCrsSAtt);
                        db.SaveChanges();
                        break;
                }
                lblRowsMsg.Show();
            }
            FillComboBox();
        }
    }
}
