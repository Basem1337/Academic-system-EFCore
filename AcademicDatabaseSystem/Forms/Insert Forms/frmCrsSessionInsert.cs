using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.Forms;
using AcademicDatabaseSystem.Models;

namespace WinFormsApp
{
    public partial class frmCrsSessionInsert : Form
    {
        DatabaseContext db = new();
        public frmCrsSessionInsert()
        {
            InitializeComponent();
            lblRowsMsg.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmInsertMain mainMenu = new frmInsertMain();
            mainMenu.Show();
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            lblRowsMsg.Hide();

            if (string.IsNullOrWhiteSpace(txtInsID.Text) || string.IsNullOrWhiteSpace(txtCrsID.Text) || string.IsNullOrWhiteSpace(txtDate.Text))
            {
                lblRowsMsg.ForeColor = Color.Red;
                lblRowsMsg.Text = "There are fields that cannot be empty..";
                lblRowsMsg.Show();
                return;
            }

            CourseSession newRecord = new()
            {
                CrsID = Convert.ToInt32(txtCrsID.Text),
                InsID = Convert.ToInt32(txtInsID.Text),
                Title = txtTitle.Text,
                Date = Convert.ToDateTime(txtDate.Text),
            };

            db.Crs_Sessions.Add(newRecord);
            db.SaveChanges();
            lblRowsMsg.ForeColor = Color.DodgerBlue;
            lblRowsMsg.Text = "1 Row Added Successfully";
            lblRowsMsg.Show();
        }

    }
}
