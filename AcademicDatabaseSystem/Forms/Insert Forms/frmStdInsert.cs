using AcademicDatabaseSystem.Context;
using AcademicDatabaseSystem.DataRepository;
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
            lblFname.Hide();
            lblLname.Hide();
            lblPhone.Hide();
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

            lblFname.Hide();
            lblLname.Hide();
            lblPhone.Hide();

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

            if (string.IsNullOrWhiteSpace(txtFName.Text) || string.IsNullOrWhiteSpace(txtLName.Text))
            {
                lblRowsMsg.ForeColor = Color.Red;
                lblRowsMsg.Text = "There are fields that cannot be empty..";
                lblRowsMsg.Show();
                return;
            }

            Student newRecord = new()
            {
                St_FName = txtFName.Text,
                St_LName = txtLName.Text,
                St_Phone = txtPhone.Text
            };

            db.Students.Add(newRecord);
            db.SaveChanges();
            lblRowsMsg.ForeColor = Color.FromArgb(68, 187, 164);
            lblRowsMsg.Text = "1 Row Added Successfully";
            lblRowsMsg.Show();
        }

        private void frmStdInsert_Load(object sender, EventArgs e)
        {

        }
    }
}
