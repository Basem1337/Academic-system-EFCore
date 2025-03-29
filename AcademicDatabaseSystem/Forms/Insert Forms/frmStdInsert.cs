using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.Forms;
using AcademicDatabaseSystem.Models;

namespace WinFormsApp
{
    public partial class frmStdInsert : Form
    {
        DatabaseContext db = new();
        public frmStdInsert()
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
            Student newRecord = new()
            {
                St_FName = txtFName.Text,
                St_LName = txtLName.Text,
                St_Phone = txtPhone.Text
            };

            db.Students.Add(newRecord);
            db.SaveChanges();
            lblRowsMsg.Show();
        }

    }
}
