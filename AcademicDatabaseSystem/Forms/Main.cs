using System.Diagnostics;
using AcademicDatabaseSystem.Forms;

namespace WinFormsApp
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmSelect selectFrm = new frmSelect();
            selectFrm.Show();
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertMain insertFrm = new frmInsertMain();
            insertFrm.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateMain updateFrm = new frmUpdateMain();
            updateFrm.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDelete deleteFrm = new frmDelete();
            deleteFrm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void linkLinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.linkedin.com/in/baramadan/",
                UseShellExecute = true
            });

            linkLinkedIn.LinkVisited = true;
        }

        private void linkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/Basem1337",
                UseShellExecute = true
            });

            linkGitHub.LinkVisited = true;
        }

        private void linkBehance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.behance.net/baramadan",
                UseShellExecute = true
            });

            linkBehance.LinkVisited = true;
        }

        //private void frmParent_Load(object sender, EventArgs e)
        //{
        //    Environment.Exit(0);
        //}
    }
}
